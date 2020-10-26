namespace Data
{
    public interface ICommandRepository
    {
        /* These methodes are not Asyn so ...
        Models.Command GetId(int Id);
        System.Collections.Generic.IEnumerable<Models.Command> GetAll();
        */

        System.Threading.Tasks.Task<Models.Command> GetIdAsync(int Id);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Models.Command>> GetAllAsync();

    }

}