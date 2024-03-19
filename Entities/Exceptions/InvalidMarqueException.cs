using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
	public class InvalidMarqueException : Exception
	{
		public InvalidMarqueException(string message) : base(message) { }
		public override string Message => base.Message;
	}
}
