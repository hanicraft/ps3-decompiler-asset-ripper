using Microsoft.VisualBasic.CompilerServices;
using System;

namespace UMD_Ripper
{
	internal static class Idiomas
	{
		public static string VIDEO;

		public static string MUSICA;

		public static string DUMMYS;

		public static string DEMOS;

		public static string Cad_IDIOMA;

		public static string MensajeOK;

		public static string MensajeError;

		public static string Cancelado;

		public static string Actudetectada;

		public static string seccion;

		public static string descripcionAbrir;

		public static string Original;

		public static string Ripeada;

		public static void CambiaIdioma(string idioma)
		{
			string str = idioma;
			if (Operators.CompareString(str, "Español", false) == 0)
			{
				Idiomas.VIDEO = "VIDEO";
				Idiomas.MUSICA = "SONIDOS";
				Idiomas.DUMMYS = "DUMMYS";
				Idiomas.DEMOS = "DEMOS";
				Idiomas.Cad_IDIOMA = "IDIOMAS";
				Idiomas.MensajeOK = "ISO Ripeada correctamente, disfrutala!!";
				Idiomas.MensajeError = "Error desconocido en la aplicacion, porfavor contacta y hazme saber el error, asi ganamos todos";
				Idiomas.Original = "Original";
				Idiomas.Ripeada = "Ripeada";
				Idiomas.Cancelado = "Accion cancelada";
				Idiomas.Actudetectada = "Se detecto y elimino el UPDATE del juego ya que solo ocupan espacio innecesario";
				Idiomas.seccion = "Elija una Seccion";
				Idiomas.descripcionAbrir = "Selecciona la carpeta del Juego, por ejemplo BLES00239";
			}
			else if (Operators.CompareString(str, "Ingles", false) == 0)
			{
				Idiomas.VIDEO = "VIDEO";
				Idiomas.MUSICA = "SOUNDS";
				Idiomas.DUMMYS = "DUMMYS";
				Idiomas.DEMOS = "DEMOS";
				Idiomas.Cad_IDIOMA = "LANGUAGES";
				Idiomas.MensajeOK = "ISO ripped correctly, enjoy it!";
				Idiomas.MensajeError = "Unknown error in the application, please contact me and let me know the error, so we all win";
				Idiomas.Original = "Original";
				Idiomas.Ripeada = "Ripped";
				Idiomas.Cancelado = "Operation Aborted";
				Idiomas.Actudetectada = "Detected and removed the UPDATE of the game because it only take up unnecessary space";
				Idiomas.seccion = "Choose a Section";
				Idiomas.descripcionAbrir = "Select the folder of the game, for example BLES00239";
			}
			else if (Operators.CompareString(str, "Frances", false) == 0)
			{
				Idiomas.VIDEO = "VIDEO";
				Idiomas.MUSICA = "SONS";
				Idiomas.DUMMYS = "DUMMYS";
				Idiomas.DEMOS = "DEMOS";
				Idiomas.Cad_IDIOMA = "LANGUES";
				Idiomas.MensajeOK = "ISO déchiré correctement, profitez-en!";
				Idiomas.MensajeError = "Une erreur inconnue dans la demande, s'il vous plaît contactez l'erreur et dites-moi, si nous sommes tous gagnants";
				Idiomas.Original = "Original";
				Idiomas.Ripeada = "Déchiré";
				Idiomas.Cancelado = "Action annulée";
				Idiomas.Actudetectada = "Il détecte et supprime le jeu UPDATE";
				Idiomas.seccion = "Choisissez un article";
				Idiomas.descripcionAbrir = "Sélectionnez le dossier du jeu, pour exemple BLES00239";
			}
			else if (Operators.CompareString(str, "Aleman", false) == 0)
			{
				Idiomas.VIDEO = "VIDEO";
				Idiomas.MUSICA = "SOUNDS";
				Idiomas.DUMMYS = "DUMMYS";
				Idiomas.DEMOS = "DEMOS";
				Idiomas.Cad_IDIOMA = "SPRACHEN";
				Idiomas.MensajeOK = "ISO riss richtig genießen!";
				Idiomas.MensajeError = "Unbekannter Fehler in der Anwendung, bitte kontaktieren Sie mich und lassen mich wissen, die Fehler, so dass wir alle gewinnen";
				Idiomas.Original = "Original";
				Idiomas.Ripeada = "Gerissen";
				Idiomas.Cancelado = "Aktion abgebrochen";
				Idiomas.Actudetectada = "Es erkennt und entfernt das Spiel UPDATE";
				Idiomas.seccion = "Wählen Sie eine Rubrik";
				Idiomas.descripcionAbrir = "Wählen Sie den Ordner des Spiels, zum Beispiel BLES00239";
			}
			else if (Operators.CompareString(str, "Italiano", false) == 0)
			{
				Idiomas.VIDEO = "VIDEO";
				Idiomas.MUSICA = "SUONI";
				Idiomas.DUMMYS = "DUMMYS";
				Idiomas.DEMOS = "DEMOS";
				Idiomas.Cad_IDIOMA = "LINGUE";
				Idiomas.MensajeOK = "ISO strappato correttamente, buon divertimento!";
				Idiomas.MensajeError = "Errore sconosciuto nel ricorso, si prega di contattare me e fammi sapere l'errore, così ci siamo vincere...";
				Idiomas.Original = "Originale";
				Idiomas.Ripeada = "Strappato";
				Idiomas.Cancelado = "Azione annullata";
				Idiomas.Actudetectada = "Esso rileva e rimuove il gioco UPDATE";
				Idiomas.seccion = "Scegli una sezione";
				Idiomas.descripcionAbrir = "Selezionare la cartella del gioco, per esempio BLES00239";
			}
		}
	}
}