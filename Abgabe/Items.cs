using System;
using System.Collections.Generic;

namespace Abgabe
{
   
        
        public class Item{
            
            public string name;
            public string type;
            public bool armed;
            public float lifepoints;
            public float hitpoints;
            public string information;

            public Item(string _name, string _type, bool _armed, float _lifepoints, float _hitpoints , string _information){
                name = _name;
                type = _type;
                armed = _armed;
                lifepoints = _lifepoints;
                hitpoints = _hitpoints;
                information = _information;
            } 
       
    }
}