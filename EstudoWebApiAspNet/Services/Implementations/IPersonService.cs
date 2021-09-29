using EstudoWebApiAspNet.Models;
using System.Collections.Generic;

namespace EstudoWebApiAspNet.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person Update(Person person);
        Person FindById(long id);
        void Delete(long id);

        List<Person> FindAll();
    }
}
