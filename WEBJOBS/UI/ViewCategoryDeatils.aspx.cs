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
    public partial class ViewCategoryDeatils : System.Web.UI.Page
    {
        JobManager aJobManager = new JobManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllJobsDescription();
            }
        }



        public void GetAllJobsDescription()
        {
            JobDescriptionModel aCategoryModel = new JobDescriptionModel();
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = int.Parse(Request.QueryString["id"]);

                List<JobDescriptionModel> aCategoryList = aJobManager.GetAllJobByCategoryDetails(id);
                if (aCategoryList != null)
                {
                    foreach (JobDescriptionModel aCategory in aCategoryList)
                    {
                        Panel aPanel = new Panel
                        {
                            CssClass = "aPanel"
                        };


                        LinkButton aPositionLinkButton = new LinkButton
                        {
                            Text = "<br/> Position: " + aCategory.Position,
                            CssClass = "positionLinkButton",
                            PostBackUrl = string.Format("~/UI/ViewDescription.aspx?id={0}", aCategory.Id)

                        };

                        Label aCompanyNameLabel = new Label()
                        {
                            Text = "Company Name: " + aCategory.CompanyName,
                            CssClass = "companyNameLabel"
                        };

                        Label aEducationLabel = new Label()
                        {
                            Text = "Education: " + aCategory.Education,
                            CssClass = "educationLabel"
                        };

                        Label aExperienceLabel = new Label()
                        {
                            Text = "Experience: " + aCategory.Experience + "<br/> ",
                            CssClass = "experienceLabel"
                        };

                        aPanel.Controls.Add(aPositionLinkButton);
                        aPanel.Controls.Add(new Literal { Text = "<br/>" });
                        aPanel.Controls.Add(aCompanyNameLabel);
                        aPanel.Controls.Add(new Literal { Text = "<br/>" });
                        aPanel.Controls.Add(aEducationLabel);
                        aPanel.Controls.Add(new Literal { Text = "<br/>" });
                        aPanel.Controls.Add(aExperienceLabel);

                       categoryDetailsPanel.Controls.Add(aPanel);

                    }

                }
                else
                {
                    categoryDetailsPanel.Controls.Add(new Literal { Text = "No item available" });
                }
            }



        }   
    }
}