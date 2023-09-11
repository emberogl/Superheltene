using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    /// <summary>
    /// Class SuperHero contains string attributes and lists to define the superhero.
    /// It contains a method that returns information about the hero, and
    /// methods to set hidden attributes.
    /// </summary>
    internal class SuperHero
    {
        #region Attributes
        private string _hiddenIdentity = "";
        private List<string> _personalIssues = new List<string>();
        public string Alias = "";
        public List<string> Powers = new List<string>();
        public string Mask = "";
        public string Costume = "";
        public List<string> MoralCode = new List<string>();
        public List<string> Enemies = new List<string>();
        #endregion

        // Returns information about the hero
        public string GetHeroInformation()
        {
            string info =
                $"Hidden identity: {_hiddenIdentity} \n" +
                $"Alias: {Alias} \n" +
                $"Powers: {string.Join(", ", Powers)} \n" +
                $"Mask: {Mask}  \n" +
                $"Costume: {Costume}  \n" +
                $"Moral code: {string.Join(", ", MoralCode)}  \n" +
                $"Enemies: {string.Join(", ", Enemies)}  \n" +
                $"Personal issues: {string.Join(", ", _personalIssues)}  \n";
            return info;
        }

        #region Private Attribute Methods
        public void SetIdentity(string hiddenIdentity)
        {
            _hiddenIdentity = hiddenIdentity;
        }

        public void AddPersonalIssues(string[] personalIssues)
        {
            _personalIssues.AddRange(personalIssues);
        }
        #endregion
    }
}