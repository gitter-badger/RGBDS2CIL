﻿namespace RGBDS2CIL
{
	public class PushLine : CodeLine
	{
		public PushLine(CodeLine codeLine) : base(codeLine.Code, codeLine, codeLine.Strings)
		{
			base.Comment = codeLine.Comment;
			base.Raw = codeLine.Raw;
		}
	}
}