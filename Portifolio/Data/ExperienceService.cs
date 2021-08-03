using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Portifolio.Pages.Experiences;
using static Portifolio.Pages.FetchData;

namespace Portifolio.Data
{
    public class ExperienceService
    {

        private List<Experience> experiences = new List<Experience>()
{
        new Experience{ Position = ".Net Developer", Company = "Planet Payment", StartDate = new DateTime(2019,9,9), EndDate = null,
            Description = "Current Position on Financial Company as .Net Developer", Projects = new List<string>{ "AMPS", "RSG" },
            LanguagesTools = new List<string>{ ".Net Framework", ".Net Core", "Azure DevOps", "AngularJS", "Angular", "SQL Server", "Jira"}},
        new Experience{ Position = "FullStack .Net Developer", Company = "Softwillians IT Solutions", StartDate = new DateTime(2017,5,1), EndDate = new DateTime(2019,8,31),
            Description = "FullStack Developer working for many clients in different areas and projects", Projects = new List<string>{ "EzTask", "EzProcess", "Agricola" },
            LanguagesTools = new List<string>{ ".Net Framework", ".Net Core", "Azure DevOps", "AngularJS", "Angular", "SQL Server", "Trello"}},
    };

        public Task<List<Experience>> GetForecastAsync()
        {
            return Task.FromResult(experiences);
        }
    }
}
