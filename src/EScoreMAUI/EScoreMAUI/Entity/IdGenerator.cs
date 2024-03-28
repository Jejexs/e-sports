namespace EScoreMAUI.Entity
{
    public static class IdGenerator
    {
        private static int _lastEquipeId = 0;
        private static int _lastJoueurId = 0;
        private static int _lastPartieId = 0;

        public static int GenerateEquipeId()
        {
            _lastEquipeId++;
            return _lastEquipeId;
        }

        public static int GenerateJoueurId()
        {
            _lastJoueurId++;
            return _lastJoueurId;
        }

        public static int GeneratePartieId()
        {
            _lastPartieId++;
            return _lastPartieId;
        }
    }
}