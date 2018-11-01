using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact.CRUD;
using System.IO;

namespace Contact.UserControls
{
    public partial class ctrlPersonList : UserControl
    {
        public Panel MyContainer;
        private FlowLayoutPanel flowLayoutPanel;
        public ctrlPersonList()
        {
            InitializeComponent();
        }

        public void AddContact()
        {
            RemoveControls();
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            pnlFlowLayoutContainer.Controls.Add(flowLayoutPanel);
            DataTable tbl = new PersonCrud().GetAllContact();
            foreach (DataRow row in tbl.Rows)
            {
                ctrlPerson cp = new ctrlPerson(row);
                cp.MyContainer = MyContainer;
                cp.Name = "cp" + row["id"].ToString();
                flowLayoutPanel.Controls.Add(cp);
                cp.flowPnl = flowLayoutPanel;
            }

            string path = AppDomain.CurrentDomain.BaseDirectory + "profile";
            Task t = Task.Run(() => DeleteUnusedImages(path, ref tbl)); 
        }

        public void search(string search)
        {
            RemoveControls();
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            pnlFlowLayoutContainer.Controls.Add(flowLayoutPanel);
            DataTable tbl = new PersonCrud().GetAllContact();
            string filter = string.Format("FullName Like '%{0}%' OR PrimaryEmail like '%{0}%' OR Company Like '%{0}%'", search);
            DataRow[] rows = tbl.Select(filter);
            foreach (DataRow row in rows)
            {
                ctrlPerson cp = new ctrlPerson(row);
                cp.MyContainer = MyContainer;
                cp.Name = "cp" + row["id"].ToString();
                cp.flowPnl = flowLayoutPanel;
                flowLayoutPanel.Controls.Add(cp);
            }
        }

        private void RemoveControls()
        {
            foreach (FlowLayoutPanel ctrl in pnlFlowLayoutContainer.Controls.OfType<FlowLayoutPanel>())
            {
                pnlFlowLayoutContainer.Controls.Remove(ctrl);
                ctrl.Dispose();            
            }
        }

        private void DeleteUnusedImages(string path, ref DataTable tbl)
        {
            string[] files = Directory.GetFiles(path);
            List<string> usedfiles = (from DataRow row in tbl.Rows
                                  select path + "\\" + row.Field<string>("ProfileImage")
                                  ).ToList();
            usedfiles.Add(path + "\\EE306F1B79D542BF9A58F6BAFDC1F556.jpg");
            List<string> unused = files.Except(usedfiles).ToList();
            foreach (string file in unused)
            {
                try
                {
                    File.Delete(file);
                }
                catch //Either R/W permission or Access permission or file being used exception
                {
                }
                
            }
        }
        
    }
}
