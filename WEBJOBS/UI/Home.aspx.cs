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
    public partial class Home : System.Web.UI.Page
    {
        JobManager aJobManager = new JobManager();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
               
                GetAllJobsDescription();
                GetAllCategory();
            }
        }


        public void GetAllJobsDescription()
        {

            JobDescriptionModel aCategoryModel = new JobDescriptionModel();

            List<JobDescriptionModel> aCategoryList = aJobManager.GetAllJobDescription();
            if(aCategoryList !=null)
            {
                foreach (JobDescriptionModel aCategory in aCategoryList)
                {
                   
                    Panel aPanel = new Panel
                    {
                        CssClass="aPanel"
                    };
                    

                    LinkButton aPositionLinkButton = new LinkButton
                    {
                        Text= "<br/> Position: "+aCategory.Position,
                        CssClass="positionLinkButton",
                        PostBackUrl = string.Format("~/UI/ViewDescription.aspx?id={0}", aCategory.Id)                     
                    };

                    Label aCompanyNameLabel = new Label()
                    {
                        Text="Company Name: "+aCategory.CompanyName,
                        CssClass="companyNameLabel"
                    };

                    Label aEducationLabel = new Label()
                    {
                        Text="Education: "+aCategory.Education,
                        CssClass="educationLabel"
                    };

                    Label aExperienceLabel = new Label()
                    {
                        Text = "Experience: " + aCategory.Experience + "<br/> ",
                        CssClass="experienceLabel"
                    };

                    aPanel.Controls.Add(aPositionLinkButton);
                    aPanel.Controls.Add(new Literal { Text = "<br/>" });
                    aPanel.Controls.Add(aCompanyNameLabel);
                    aPanel.Controls.Add(new Literal { Text = "<br/>" });
                    aPanel.Controls.Add(aEducationLabel);
                    aPanel.Controls.Add(new Literal { Text = "<br/>" });
                    aPanel.Controls.Add(aExperienceLabel);

                    descriptionPanel.Controls.Add(aPanel);

                }

            }
                else
                {
                    descriptionPanel.Controls.Add(new Literal { Text = "No item available" });
                }

           
        }

        public void GetAllCategory()
        {
            CategoryModel aCategoryModel = new CategoryModel();
            List<CategoryModel> aCategoryList = aJobManager.GetAllCategory();

            foreach (CategoryModel Category in aCategoryList)
            {
                
                Panel aPanel = new Panel();

                LinkButton alinkButton = new LinkButton
                {
                    Text=Category.Category +"<br/>",
                    CssClass="viewCategory",
                    PostBackUrl = string.Format("~/UI/ViewCategoryDeatils.aspx?id={0}", Category.Id)
                };

                aPanel.Controls.Add(alinkButton);
                aPanel.Controls.Add(new Literal { Text = "<br/>" });

                categoryPanel.Controls.Add(aPanel);
            }

        }
    }
}