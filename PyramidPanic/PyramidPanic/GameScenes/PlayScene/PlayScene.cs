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


namespace PyramidPanic
{
    public class PlayScene : IState // De class PlayScene implementeert de interface IState
    {
        //Fields van de class PlayScene
        private PyramidePanic game;
        private Scorpion scorpion, scorpion1;
        private Beetle beetle, beetle1;
        private Explorer explorer;
        //private Explorer explorer;

        // Constructor van de StartScene-class krijgt een object game mee van he type PyramidPanic
        public PlayScene(PyramidePanic game)
        {
            this.game = game;
            this.Intialize();
        }
        // Intialize methode. Deze methode initialiseert (geeft startwaarden aan variabelen)
        // Void wil zeggen dat er niets teruggegeven wordt.
        public void Intialize()
        {
            this.LoadContent();
        }
        // LoadConctent methode. Deze methode maakt nieuwe objecten aan van de verschillende
        // classes.
        public void LoadContent()
        {
            this.scorpion = new Scorpion(this.game, new Vector2(300f,188f));
            this.scorpion1 = new Scorpion(this.game, new Vector2(350f, 238f));
            this.beetle = new Beetle(this.game, new Vector2(100f, 300f));
            this.beetle1 = new Beetle(this.game, new Vector2(150f, 350f));
            this.explorer = new Explorer(this.game, new Vector2(0f, 240f));
            //this.explorer = new Explorer(this.game);
        }
        //Update methode. Deze methode wordt normaal 60 maal per seconde aangeroepen.
        // en update alle variabelen, methods enz........
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.B))
            {
                this.game.IState = this.game.StartScene;
            }
            this.scorpion1.Update(gameTime);
            this.scorpion.Update(gameTime);
            this.beetle.Update(gameTime);
            this.beetle1.Update(gameTime);
            this.explorer.Update(gameTime);
           // this.explorer.Update(gameTime);
        }
        // Draw methode. Deze methode wordt normaal 60 maal per seconde aangeroepen en
        // tekent de tectures op het canvas.
        public void Draw(GameTime gameTime)
        {

            this.game.GraphicsDevice.Clear(Color.Pink);
            this.scorpion.Draw(gameTime);
            this.scorpion1.Draw(gameTime);
            this.beetle.Draw(gameTime);
            this.beetle1.Draw(gameTime);
            this.explorer.Draw(gameTime);
           // this.explorer.Draw(gameTime);

        }
    }
}
