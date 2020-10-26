using System;
using System.Linq;

namespace Data
{
    public class ThisIsNotAGoodRepository : Object
    {
        public ThisIsNotAGoodRepository() : base()
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

        public Models.Command GetById(int Id)
        {
            Models.Command foundedCommand =
            Commands.
            Where(current => current.Id == Id).
            FirstOrDefault();

            return foundedCommand;
        }

        public System.Collections.Generic.IEnumerable<Models.Command> GetAll()
        {
            return Commands;

        }
    }
}