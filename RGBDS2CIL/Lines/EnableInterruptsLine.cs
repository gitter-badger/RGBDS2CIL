﻿namespace RGBDS2CIL
{
	public class EnableInterruptsLine : CodeLine
	{
		public EnableInterruptsLine(CodeLine codeLine) : base(codeLine.Code, codeLine, codeLine.Strings)
		{
			base.Comment = codeLine.Comment;
			base.Raw = codeLine.Raw;
		}
	}
}