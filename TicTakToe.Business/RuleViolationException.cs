using System;

namespace TicTakToe.Business
{
	public class RuleViolationException : ApplicationException
	{
		public RuleViolationException(string message)
			: base(message)
		{
		}
	}
}