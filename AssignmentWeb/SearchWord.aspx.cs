using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace AssignmentWeb
{
    public partial class SearchWord : System.Web.UI.Page
    {
        // Store words and translations in Session for persistence
        private List<KeyValuePair<string, string>> Words
        {
            get
            {
                if (Session["Words"] == null)
                    Session["Words"] = new List<KeyValuePair<string, string>>();
                return (List<KeyValuePair<string, string>>)Session["Words"];
            }
            set
            {
                Session["Words"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Words.Count == 0)
                {
                    Words.Add(new KeyValuePair<string, string>("Hello", ""));
                    Words.Add(new KeyValuePair<string, string>("Goodbye", ""));
                    Words.Add(new KeyValuePair<string, string>("Home", ""));
                    Words.Add(new KeyValuePair<string, string>("Thank you", ""));
                }
                BindGrid();
                pnlAddTranslation.Visible = false;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = txtSearch.Text.Trim();
            var found = Words.FirstOrDefault(w => w.Key.Equals(searchWord, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(found.Key))
            {
                if (string.IsNullOrEmpty(found.Value))
                {
                    Label1.Text = $"Word '{found.Key}' found. Please add its translation.";
                    pnlAddTranslation.Visible = true;
                    txtTranslation.Text = "";
                }
                else
                {
                    Label1.Text = $"Word: {found.Key}, Translation: {found.Value}";
                    pnlAddTranslation.Visible = false;
                }
            }
            else
            {
                Response.Redirect("WordNotFound.aspx?word=" + Server.UrlEncode(searchWord));
            
        }
        }

        protected void btnAddTranslation_Click(object sender, EventArgs e)
        {
            string word = txtSearch.Text.Trim();
            string translation = txtTranslation.Text.Trim();

            var index = Words.FindIndex(w => w.Key.Equals(word, StringComparison.OrdinalIgnoreCase));
            if (index >= 0)
            {
                Words[index] = new KeyValuePair<string, string>(word, translation);
                Label1.Text = $"Translation for '{word}' added: {translation}";
                pnlAddTranslation.Visible = false;
                BindGrid();
            }
        }

        private void BindGrid()
        {
            gvWords.DataSource = Words;
            gvWords.DataBind();
        }
    }
}