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
        public string alias = "";
        public List<string> powers = new List<string>();
        public string mask = "";
        public string costume = "";
        public List<string> moralCode = new List<string>();
        public List<string> enemies = new List<string>();
        #endregion

        // Returns information about the hero
        public string GetHeroInformation()
        {
            string info =
                $"Hidden identity: {_hiddenIdentity} \n" +
                $"Alias: {alias} \n" +
                $"Powers: {string.Join(", ", powers)} \n" +
                $"Mask: {mask}  \n" +
                $"Costume: {costume}  \n" +
                $"Moral code: {string.Join(", ", moralCode)}  \n" +
                $"Enemies: {string.Join(", ", enemies)}  \n" +
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