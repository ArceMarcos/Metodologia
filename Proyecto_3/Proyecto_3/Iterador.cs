﻿using System;

namespace Proyecto_3
{
	
	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();
	}
}

