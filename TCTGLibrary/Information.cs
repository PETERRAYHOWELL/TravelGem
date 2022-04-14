using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTGLibrary
{
    public class Information
    {
        #region//Variables
        protected string info_Id;
        protected string companyName;
        protected string companyPic;
        protected string companyInfo;
        protected string packageSelection;
        protected float price;
        protected string mapLink;
        protected string selectionLocation;
        protected string companyAddress;
        protected string companyNumber;
        protected string companyEmail;
        #endregion


        #region//Properties
        public string Info_Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPic { get; set; }
        public string CompanyInfo { get; set; }
        public string PackageSelection { get; set; }
        public float Price { get; set; }
        public string MapLink { get; set; }
        public string SelectionLocation { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyNumber { get; set; }
        public string CompanyEmail { get; set; }
        #endregion


        #region//Constructors
        //default constructor
        public Information()
        {
            info_Id = "";
            companyName = "";
            companyPic = "";
            companyInfo = "";
            packageSelection = "";
            price = 0.0f;
            mapLink = "";
            selectionLocation = "";
            companyAddress = "";
            companyNumber = "";
            companyEmail = "";
            
        }

        //primary constructor
        public Information(string Info_Id, string CompanyName, string CompanyPic, string CompanyInfo, string PackageSelection,
                            float Price, string MapLink, string SelectionLocation, string CompanyAddress, string CompanyNumber, 
                            string CompanyEmail)
            
            
        {
            info_Id = Info_Id;
            companyName = CompanyName;
            companyPic = CompanyPic;
            companyInfo = CompanyInfo;
            packageSelection = PackageSelection;
            price = Price;
            mapLink = MapLink;
            selectionLocation = SelectionLocation;
            companyAddress = CompanyAddress;
            companyNumber = CompanyNumber;
            companyEmail = CompanyEmail;
        }

        //copy constructor
        public Information(Information information)
        {
            info_Id = information.Info_Id;
            companyName = information.CompanyName;
            companyPic = information.CompanyPic;
            companyInfo = information.CompanyInfo;
            packageSelection = information.PackageSelection;
            price = information.Price;
            mapLink = information.MapLink;
            selectionLocation = information.SelectionLocation;
            companyAddress = information.CompanyAddress;
            companyNumber = information.CompanyNumber;
            companyEmail = information.CompanyEmail;
        }
        #endregion

    }
}
