﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonoGame.Extended.Screens;
using Microsoft.Xna.Framework;
using System;
using MonoGame.Extended.BitmapFonts;
using Microsoft.Xna.Framework.Content;
using MorpheusInTheUnderworld.Classes;
using MonoGame.Extended.Screens.Transitions;

namespace MorpheusInTheUnderworld.Screens
{
    class MainMenuScreen : MenuScreen
    {

        string Title = "Morpheus In The Underworld";

        public MainMenuScreen(Game game) : base(game)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void LoadContent()
        {
            base.LoadContent();
            AddMenuItem("New Game!", () => { ScreenManager.LoadScreen(new CutsceneScreen(Game, Scene.Start), new FadeTransition(GraphicsDevice, Color.Black, 1.2f)); });
#if DEBUG
            //AddMenuItem("Testing combat screen", () => { ScreenManager.LoadScreen(new CombatScreen(Game)); });
#endif
            AddMenuItem("Options", () => { ScreenManager.LoadScreen(new OptionMenuScreen(Game)); });

            AddMenuItem("Exit", () => { Game.Exit(); });
        }

        public override void Draw(Microsoft.Xna.Framework.GameTime gameTime)
        {
            base.Draw(gameTime);

            spriteBatch.Begin();
            spriteBatch.DrawString(Font, Title, new Vector2((Viewport.Width / 2) - (Font.MeasureString(Title).Width)/2, 20), Color.Red);
            spriteBatch.End();
        }
    }
}
