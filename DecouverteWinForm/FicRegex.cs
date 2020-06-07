using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DecouverteWinForm
{
	public partial class FicRegex : Form
	{
		public FicRegex()
		{
			InitializeComponent();
		}

		private void FicRegex_Load(object sender, System.EventArgs e)
		{
			textBoxRegex_TextChanged(null, null);
		}

		// renvoie un booléen sur la validité d'une regex
		private bool Validite(string regex)
		{
			try
			{
				Regex temp = new Regex(regex);
				return true;
			}
			catch
			{
				return false;
			}
		}

		private bool Correspondance(string regex, string aVerifier, RegexOptions options)
		{
			if (Validite(regex)) // si on trouve une correspondance
			{
				Regex exp = new Regex(regex, options);
				return exp.IsMatch(aVerifier); // renvoie true si on trouve quelque chose
			}

			return false;
		}

		private MatchCollection Correspondances(string regex, string aVerifier, RegexOptions options)
		{
			if (Validite(regex))
			{
				Regex exp = new Regex(regex, options);
				return exp.Matches(aVerifier); // si on trouve une correspondance

			}

			return null;
		}

		private void MettreEnEvidence(MatchCollection correspondances, RichTextBox richTextBox)
		{
			richTextBox.Select(0, richTextBox.Text.Length); // sélectionne tout le text
			richTextBox.SelectionBackColor = Color.Transparent; // mets une couleur transparente

			foreach (Match correspondance in correspondances)
			{
				richTextBox.Select(correspondance.Index, correspondance.Length); // sélectionne la correspondance
				richTextBox.SelectionBackColor = Color.Orange; // mets la couleur
			}
		}

		// modifie tous les résultats trouvés dans aVerifier par texteRemplacement
		private string Remplacer(string regex, string aVerifier, RegexOptions options, string texteRemplacement)
		{
			if (Validite(regex)) // si on trouve une correspondance
			{
				Regex exp = new Regex(regex, options);
				return exp.Replace(aVerifier, texteRemplacement); // renvoie true si on trouve quelque chose
			}

			return "Regex incorrecte";
		}

		private string[] Separer(string regex, string aVerifier, RegexOptions options)
		{
			if (Validite(regex)) // si on trouve une correspondance
			{
				Regex exp = new Regex(regex, options);
				return exp.Split(aVerifier); // renvoie true si on trouve quelque chose
			}

			return new[]{ "Regex incorrecte" };
		}

		private void textBoxRegex_TextChanged(object sender, System.EventArgs e)
		{
			if (checkBoxIsValid.Checked = Validite(textBoxRegex.Text))
			{
				checkBoxCorrespondance.Checked = Correspondance(
					textBoxRegex.Text, // la regex
					richTextBoxATraiter.Text, // le texte à traiter
					checkBoxCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase // si pas check on ignore la casse
				);

				MettreEnEvidence(
					Correspondances(
						textBoxRegex.Text, // la regex
						richTextBoxATraiter.Text, // le texte à traiter
						checkBoxCasse.Checked
							? RegexOptions.None
							: RegexOptions.IgnoreCase // si pas check on ignore la casse
					),
					richTextBoxATraiter
				);
			}
		}

		private void richTextBoxATraiter_Leave(object sender, System.EventArgs e)
		{
			textBoxRegex_TextChanged(null, null);
		}

		private void checkBoxCasse_CheckedChanged(object sender, System.EventArgs e)
		{
			textBoxRegex_TextChanged(null, null);
		}

		private void checkBoxRemplacer_CheckedChanged(object sender, System.EventArgs e)
		{
			if (Validite(textBoxRegex.Text) && checkBoxRemplacer.Checked)
			{
				MessageBox.Show(Remplacer(
					textBoxRegex.Text,
					richTextBoxATraiter.Text,
					checkBoxCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase,
					textBoxRemplacement.Text
				));
			}

			checkBoxRemplacer.Checked = false;
		}

		private void checkBoxSeparer_CheckedChanged(object sender, System.EventArgs e)
		{
			if (Validite(textBoxRegex.Text) && checkBoxSeparer.Checked)
			{
				string[] temps = Separer(
					textBoxRegex.Text,
					richTextBoxATraiter.Text,
					checkBoxCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase
				);

				foreach (string temp in temps)
					MessageBox.Show(temp);
			}

			checkBoxRemplacer.Checked = false;
		}
	}
}
