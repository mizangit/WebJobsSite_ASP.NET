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
    public partial class ViewDescription : System.Web.UI.Page
    {
        JobManager aJobManager = new JobManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            viewId();
        }


        public void viewId()
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))

            {
                int id = int.Parse(Request.QueryString["id"]);

                JobDescriptionModel aDescription = aJobManager.GetAjobDescription(id);
                Panel aPanel = new Panel();

                Label PositionLabel = new Label
                {
                    Text="<br/> Position: "+aDescription.Position,
                    CssClass="positionLabel"
                };

                Label CompanyNameLabel = new Label
                {
                    Text = "Company Name: " + aDescription.CompanyName,
                    CssClass = "companyNameLabel"
                };

                Label EducationLabel = new Label
                {
                    Text = "Education: " + aDescription.Education,
                    CssClass = "educationLabel"
                };
                
                 Label ExperienceLabel = new Label
                {
                    Text = "Experience: " + aDescription.Experience,
                    CssClass = "experienceLabel"
                };

                 Label DescriptionLabel = new Label
                {
                    Text = "Description: " + aDescription.Description,
                    CssClass = "descriptionLabel"
                };
                 Label VacanciesLabel = new Label
                {
                    Text = "Vacancies: " + aDescription.Vacancies,
                    CssClass = "VacanciesLabel"
                };
                 Label SalaryLabel = new Label
                {
                    Text = "Salary: " + aDescription.Salary + "<br/>",
                    CssClass = "SalaryLabel"
                };

                 Button applyButton = new Button
                 {
                    Text="Apply",
                    CssClass="applyButton"
                 };

                 aPanel.Controls.Add(PositionLabel);
                 aPanel.Controls.Add(new Literal { Text = "<br/>" });
                 aPanel.Controls.Add(CompanyNameLabel);
                 aPanel.Controls.Add(new Literal { Text = "<br/>" });
                 aPanel.Controls.Add(VacanciesLabel);             
                 aPanel.Controls.Add(new Literal { Text = "<br/>" });
                 aPanel.Controls.Add(EducationLabel);
                 aPanel.Controls.Add(new Literal { Text = "<br/>" });
                 aPanel.Controls.Add(ExperienceLabel);
                 aPanel.Controls.Add(new Literal { Text = "<br/>" });
                 aPanel.Controls.Add(DescriptionLabel);
                 aPanel.Controls.Add(new Literal { Text = "<br/>" });
                 aPanel.Controls.Add(SalaryLabel);
                 aPanel.Controls.Add(new Literal { Text = "<br/>" });
                 aPanel.Controls.Add(applyButton);
                 aPanel.Controls.Add(new Literal { Text = "<br/>" });

                 descriptionPanel.Controls.Add(aPanel);
            }

        }
    }
}