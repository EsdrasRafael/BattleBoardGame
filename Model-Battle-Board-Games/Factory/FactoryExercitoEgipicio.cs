﻿namespace BattleBoardGame.Model.Factory
{
    class FactoryExercitoEgipicio : AbstractFactoryExercito
    {
        public override Arqueiro CriarArqueiro()
        {
            return new ArqueiroEgipicio();
        }

        public override Cavaleiro CriarCavalaria()
        {
            return new CavaleiroEgipicio();
        }

        public override Guerreiro CriarGuerreiro()
        {
            return new GuerreiroEgipicio();
        }
    }
}
