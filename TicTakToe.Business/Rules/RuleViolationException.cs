using System;
using System.Collections.Generic;
using System.Text;

namespace TicTakToe.Business.Rules
{
    public class RuleViolationException : ApplicationException
    {
        private readonly IEnumerable<RuleViolation> _errors;

        public RuleViolationException(IEnumerable<RuleViolation> errors)
        {
            _errors = errors;
        }

        public IEnumerable<RuleViolation> Errors
        {
            get { return _errors; }
        }

        public override string Message
        {
            get
            {
                var builder = new StringBuilder();
                foreach (RuleViolation result in _errors)
                {
                    builder.AppendLine(result.Message);
                }
                return builder.ToString();
            }
        }
    }
}