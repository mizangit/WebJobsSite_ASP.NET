using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEBJOBS.Model;
using WEBJOBS.BLL;

namespace WEBJOBS.UI
{
    public partial class Admin : System.Web.UI.Page
    {

        JobManager aJobmanager = new JobManager();
      
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDropDownList();
            }

        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            InsertJobDescription();
        }

        public void LoadDropDownList()
        {
            CategoryModel aCategoryModel = new CategoryModel();
            categoryDropDownList.DataSource = aJobmanager.GetAllCategory();
            categoryDropDownList.DataTextField = "Category";
            categoryDropDownList.DataValueField = "Id";
            categoryDropDownList.DataBind();
        }
        protected void uploadcategoryButton_Click(object sender, EventArgs e)
        {
            InsertCategory();
            

        }


        public void InsertCategory()
        {
            CategoryModel aCategoryModel = new CategoryModel();

            aCategoryModel.Category = categoryTextBox.Text;

            string message = aJobmanager.InsertCategory(aCategoryModel);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "alert('" + message + "')", true);
            categoryTextBox.Text = string.Empty;

        }

        public void InsertJobDescription()
        {
            JobDescriptionModel aDescriptionModel = new JobDescriptionModel();




            aDescriptionModel.Category = categoryDropDownList.SelectedValue.ToString();
            aDescriptionModel.Position = positionTextBox.Text;
            aDescriptionModel.CompanyName = companynameTextBox.Text;
            aDescriptionModel.Education = educationTextBox.Text;
            aDescriptionModel.Experience = experienceTextBox.Text;
            aDescriptionModel.Salary = salaryTextBox.Text;
            aDescriptionModel.Vacancies = vacanciesTextBox.Text;
            aDescriptionModel.Description = descriptionTextBox.Text;

            string message = aJobmanager.InsertJobDescription(aDescriptionModel);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "alert('"+message+"')", true);

            positionTextBox.Text = string.Empty;
            companynameTextBox.Text = string.Empty;
            educationTextBox.Text = string.Empty;
            experienceTextBox.Text = string.Empty;
            salaryTextBox.Text = string.Empty;
            vacanciesTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
        }






    }
}