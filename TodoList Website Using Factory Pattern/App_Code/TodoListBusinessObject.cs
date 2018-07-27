using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class TodoListBusinessObject
{

    string emailID, phone, pwd, country, securityQuestion, securityAnswer,title, description, titleNew, titleOld;
    int zipcode ;
    string dateOfBirth, createdDate;
    bool isActive, isArchive;
    
    
    public string name 
    { 
        get;
        set;
    }

    public string EmailID
    {

        get
        {
            return emailID;
        }
        set
        {
            emailID = value;
        }

    }

    public string Pwd
    {

        get
        {
            return pwd;
        }

        set
        {
            pwd = value;
        }
    }

    public string Country
    {

        get
        {
            return country;
        }

        set
        {
            country = value;
        }
    }

    public string DateOfBirth
    {
        get
        {
            return dateOfBirth;
        }
        set
        {
            dateOfBirth = value;
        }
    }

    public string Phone
    {

        get
        {
            return phone;
        }

        set
        {
            phone = value;
        }
    }

    public int ZipCode
    {

        get
        {
            return zipcode;
        }

        set
        {
            zipcode = value;
        }
    }

    public bool IsActive
    {

        get
        {
            return isActive;
        }

        set
        {
            isActive = value;
        }
    }

    public bool IsArchive
    {

        get {
            return isArchive;
        }
        set {

            isArchive = value;
        }
    }

    public string SecurityQuestion
    {

        get
        {
            return securityQuestion;
        }
        set
        {
            securityQuestion = value;
        }

    }

    public string SecurityAnswer
    {

        get
        {
            return securityAnswer;
        }
        set
        {
            securityAnswer = value;
        }

    }

    public string Title {
        get 
        { return title; } 
        set { title = value; } 
    }

    public string Description { 
        get
        { return description; } 
        set
        { description = value; } }

    public string CreatedDate {
        get { return createdDate; }
        set { createdDate = value; }
    }

    public string TitleOld { 
        get { return titleOld; }
        set { titleOld = value; } 
    }

    public string TitleNew { 
        get { return titleNew; }
        set { titleNew = value; } 
    }

}
