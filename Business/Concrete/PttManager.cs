using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)//constructer method (new yapıldığında çalışır)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager();
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.Name + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.Name + " için maske verilemez.");
            }
        }
    }
}
