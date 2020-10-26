using System.Runtime.Intrinsics.X86;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Security.AccessControl;
using System.Reflection;
using System;
using System.Linq;

namespace Data
{
    public class CommandRepository : Object, ICommandRepository
    {
        public CommandRepository() : base()
        {

        }
        private System.Collections.Generic.List<Models.Command> _commands;

        protected virtual System.Collections.Generic.List<Models.Command> Commands
        {
            get
            {
                if (_commands == null)
                {
                    _commands = new System.Collections.Generic.List<Models.Command>();
                }
                if (_commands.Any() == false)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        Models.Command newCommand = new Models.Command
                        {
                            Id = i,
                            Line = $"Line {i}",
                            HowTo = $"How to {i}",
                            Platform = $"Platfor {i}",

                        };
                        _commands.Add(newCommand);
                    }
                }
                return _commands;
            }
        }
        /* these are not Async so...
        public System.Collections.Generic.IEnumerable<Models.Command> GetAll()
        {
            return Commands;

        }

        public Models.Command GetId(int Id)
        {
            Models.Command foundedCommand =
           Commands.
           Where(current => current.Id == Id).
           FirstOrDefault();

            return foundedCommand;
        }
        */
        public async System.Threading.Tasks.Task<Models.Command> GetIdAsync(int Id)
        {
            /* this is for Async database
           Models.Command foundedCommand =
           await Mydatabasecontext.Commands.
           Where(current => current.Id == Id).
           FirstOrDefaultAsnc();
           */
            Models.Command foundedCommand = null;

            await System.Threading.Tasks.Task.Run(() =>
            {
                foundedCommand =
                Commands
                .Where(current => current.Id == Id)
                .FirstOrDefault();
            });
            return foundedCommand;
        }
        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Models.Command>> GetAllAsync()
        {
            System.Collections.Generic.IEnumerable<Models.Command> result = null;
            await System.Threading.Tasks.Task.Run(() =>
            {
                result = Commands;
            });
            return result;
        }
    }
}