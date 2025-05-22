using System;

namespace Proyecto_4
{

	public interface IAlumno 
	{
		string getName();
		int yourAnswerIs(int question);
		void setScore(int score);
		string showResult();
		bool equals(Student student);
		bool lessThan(Student student);
		bool greaterThan(Student student);
	}
}
