﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrustructure.Plans.Designer
{
	public enum ResizeDirection
	{
		None = 0,
		Top = 1,
		Left = 2,
		Bottom = 4,
		Right = 8,
		TopLeft = Top | Left,
		TopRight = Top | Right,
		BottomLeft = Bottom | Left,
		BottomRight = Bottom | Right,
	}
}
