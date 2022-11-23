﻿namespace IUP.Toolkits.Matrices
{
    /// <summary>
    /// Перечисление, представляющее правило смещения по высоте при изменении размера матрицы.
    /// </summary>
    public enum HeightResizeRule : byte
    {
        /// <summary>
        /// Смещение происходит по верхней стороне.
        /// </summary>
        Up = 0,
        /// <summary>
        /// Смещение происходит по нижней стороне.
        /// </summary>
        Down = 1,
        /// <summary>
        /// Смещение происходит по центру; в случае смещения на нечётное число приоритет отдаётся верхней стороне.
        /// </summary>
        CenterUp = 2,
        /// <summary>
        /// Смещение происходит по центру; в случае смещения на нечётное число приоритет отдаётся нижней стороне.
        /// </summary>
        CenterDown = 3
    }
}
