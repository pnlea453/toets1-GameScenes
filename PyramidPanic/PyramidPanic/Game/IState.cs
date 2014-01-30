﻿// Met using kan je een XNA codebibliotheek toevoegen en gebruiken in je class
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

//Namespace 
namespace PyramidPanic
{
    // geeft de update en draw methode mee met de gameTime method
   public interface IState
    {
       void Update(GameTime gameTime);
       void Draw(GameTime gameTime);
    }
}
