using System;
using System.Windows.Forms;
using System.Collections;

public class Stagiaire
{
	int NumInscrit;
	String Nom;
	String Prenom;
	double Note1;
	double Note2;
	double Moyenne;
	ArrayList TStagiaire;



	public bool EQUAL(Stagiaire s1, Stagiaire s2)
    {
		if (s1.NumInscrit == s2.NumInscrit)
				return true;
		return true;
	}
	public double CALCUL(double note1, double note2)
    {
		double moy = 0; 
		moy = note1 + note2 / 2;
		return moy;
	}


}
