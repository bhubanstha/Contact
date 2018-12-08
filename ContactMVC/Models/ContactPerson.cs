using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact.Model;
using System.Data;

namespace ContactMVC.Models
{
  public class ContactPerson: Person
  {
    public HttpPostedFileBase ProfilePicture { get; set; }

    public ContactPerson GetPerson(DataRow row)
    {
      if(row != null)
      {
        this.FullName = row["FullName"].ToString();
        this.Id = Convert.ToInt32(row["Id"]);
        this.Address = row["Address"].ToString();
        this.PrimaryEmail = row["PrimaryEmail"].ToString();
        this.GroupId = Convert.ToInt32(row["GroupId"]);
        this.Mobile1 = row["Mobile1"].ToString();
        this.Mobile2 = row["Mobile2"].ToString();
        this.Relation = row["Relation"].ToString();
        this.BirthDay = row["Birthday"] == DBNull.Value? DateTime.MinValue: Convert.ToDateTime(row["Birthday"]);
        this.Company = row["Company"].ToString();
        this.Title = row["Title"].ToString();
        this.Website = row["Website"].ToString();
        this.ProfEmail = row["ProfEmail"].ToString();
        this.Telephone1 = row["Telephone1"].ToString();
        this.Telephone2 = row["Telephone2"].ToString();
        this.ProfMobile1 = row["ProfMobile1"].ToString();
        this.ProfMobile2 = row["ProfMobile2"].ToString();
        this.Fax = row["Fax"].ToString();
        this.Note = row["Note"].ToString();
        this.Skype = row["Skype"].ToString();
        this.WindowsLive = row["windowsLive"].ToString();
        this.Yahoo = row["Yahoo"].ToString();
        this.Hangout = row["Hangout"].ToString();
        this.Gmail = row["Gmail"].ToString();
        this.Facebook = row["Facebook"].ToString();
        this.ImageName = row["ProfileImage"].ToString();
      }
      return this;
    }
  }


}