using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonRepository.Interface;
using PersonRepository.Service;
using PersonRepository.CSV;
using PersonRepository.SQL;

namespace PeopleViewer
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository(string repositoryType)
        {
            IPersonRepository repo = null;
            switch(repositoryType)
            {
                case "Service": repo = new ServiceRepository();
                    break;
                case "CSV": repo = new CSVRepository();
                    break;
                case "SQL": repo = new SQLRepository();
                    break;
                default:
                    throw new ArgumentException("Invalid Repository Type");
            }

            return repo;
        }
    }
}
