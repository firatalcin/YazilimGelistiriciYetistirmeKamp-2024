using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyMask(Person person);
        List<Person> GetList();
        public bool CheckPerson(Person person);
    }
}
