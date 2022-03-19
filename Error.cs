using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
	public enum ErrorCode
	{
		IndexOutsideLimit,
		UnableToOpenFile, //
		NegativePrice
	};

	public class Error : Exception
	{
		private ErrorCode code;
		public ErrorCode Code { get => this.code; }

		public Error(ErrorCode code)
        {
			this.code = code;
		}

		public override string ToString()
        {
			switch (code)
			{
				case ErrorCode.IndexOutsideLimit:
					return "Index is outside the limit";
				case ErrorCode.UnableToOpenFile:
					return "Unable to open file";
				case ErrorCode.NegativePrice:
					return "Price is negative";
				default:
					return "";
			}
		}
	};
}
