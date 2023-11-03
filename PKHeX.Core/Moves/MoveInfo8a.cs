using System;

namespace PKHeX.Core;

/// <summary>
/// Details about moves in <see cref="EntityContext.Gen8a"/>
/// </summary>
internal static class MoveInfo8a
{
    public static ReadOnlySpan<byte> MovePP_LA => new byte[]
    {
        00, 35, 25, 10, 15, 20, 20, 10, 10, 10, 35, 30, 05, 10, 20, 30, 25, 35, 20, 15,
        20, 20, 25, 20, 30, 05, 10, 15, 15, 15, 25, 20, 05, 30, 15, 20, 20, 10, 05, 30,
        20, 20, 20, 30, 20, 40, 20, 15, 20, 20, 20, 30, 25, 10, 30, 25, 05, 15, 10, 05,
        20, 20, 20, 05, 35, 20, 20, 20, 20, 20, 15, 20, 15, 10, 20, 25, 10, 20, 20, 20,
        10, 40, 10, 15, 25, 10, 20, 05, 15, 10, 05, 10, 10, 20, 10, 20, 40, 30, 20, 20,
        20, 15, 10, 40, 15, 10, 30, 10, 20, 10, 40, 40, 20, 30, 30, 20, 20, 10, 10, 20,
        05, 10, 30, 20, 20, 20, 05, 15, 15, 20, 10, 15, 35, 20, 15, 10, 10, 30, 15, 20,
        20, 10, 10, 05, 10, 25, 10, 10, 20, 15, 40, 20, 10, 05, 15, 10, 10, 10, 15, 30,
        30, 10, 10, 15, 10, 01, 01, 10, 25, 10, 05, 15, 20, 15, 10, 15, 30, 05, 40, 15,
        10, 25, 10, 20, 10, 20, 10, 10, 10, 20, 15, 20, 05, 40, 05, 05, 20, 05, 10, 05,
        10, 10, 10, 10, 20, 20, 30, 15, 10, 20, 20, 25, 05, 15, 10, 05, 20, 15, 20, 25,
        20, 05, 30, 05, 05, 20, 40, 05, 20, 40, 20, 05, 35, 10, 05, 05, 05, 15, 05, 25,
        05, 05, 10, 20, 10, 05, 15, 10, 10, 20, 15, 10, 10, 10, 20, 10, 10, 10, 10, 15,
        15, 15, 10, 20, 20, 10, 20, 20, 20, 20, 20, 10, 10, 10, 20, 20, 05, 15, 10, 10,
        15, 10, 20, 05, 05, 10, 10, 20, 05, 10, 20, 10, 20, 20, 20, 05, 05, 15, 20, 10,
        15, 20, 15, 10, 10, 15, 10, 05, 05, 10, 25, 10, 05, 20, 15, 05, 40, 15, 15, 40,
        15, 20, 20, 05, 15, 20, 15, 15, 15, 05, 10, 30, 20, 30, 20, 05, 40, 10, 05, 10,
        05, 15, 25, 25, 05, 20, 15, 10, 10, 20, 10, 20, 20, 05, 05, 10, 05, 40, 10, 10,
        05, 10, 10, 15, 10, 20, 15, 30, 10, 20, 05, 10, 10, 15, 10, 10, 05, 15, 05, 10,
        10, 30, 20, 20, 10, 10, 05, 05, 10, 05, 20, 10, 20, 10, 05, 10, 10, 20, 10, 10,
        15, 10, 15, 10, 10, 10, 10, 10, 10, 10, 30, 05, 10, 05, 10, 10, 05, 20, 20, 10,
        20, 15, 15, 15, 15, 20, 15, 15, 10, 10, 10, 20, 15, 05, 05, 15, 15, 05, 10, 05,
        15, 05, 10, 20, 05, 20, 20, 20, 20, 05, 20, 15, 05, 20, 15, 10, 10, 05, 10, 05,
        05, 10, 05, 05, 10, 05, 15, 05, 15, 10, 10, 10, 10, 10, 15, 15, 20, 15, 10, 15,
        10, 15, 10, 20, 10, 10, 10, 20, 20, 20, 20, 20, 15, 15, 15, 15, 15, 15, 20, 15,
        10, 15, 15, 15, 15, 10, 15, 10, 10, 10, 15, 15, 15, 15, 05, 05, 15, 05, 10, 10,
        10, 20, 20, 20, 10, 10, 30, 15, 10, 10, 15, 25, 10, 15, 10, 10, 10, 20, 10, 10,
        10, 10, 05, 15, 15, 05, 05, 10, 10, 10, 05, 05, 10, 05, 05, 15, 10, 05, 05, 05,
        10, 10, 10, 10, 20, 25, 10, 20, 30, 25, 20, 20, 15, 20, 15, 20, 20, 15, 10, 10,
        10, 10, 20, 10, 25, 10, 10, 10, 10, 20, 20, 05, 05, 05, 20, 10, 10, 20, 15, 20,
        20, 10, 20, 30, 10, 10, 40, 40, 20, 20, 40, 20, 20, 10, 10, 10, 10, 05, 10, 10,
        05, 05, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01,
        01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 10,
        10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 25, 15, 20, 30, 20, 15, 15, 20, 10, 15,
        15, 10, 05, 10, 10, 20, 15, 10, 15, 15, 15, 05, 15, 20, 20, 01, 01, 01, 01, 01,
        01, 01, 01, 01, 05, 05, 10, 10, 10, 20, 10, 10, 10, 05, 05, 20, 10, 10, 10, 01,
        05, 15, 05, 01, 01, 01, 01, 01, 01, 10, 15, 15, 20, 20, 20, 20, 15, 15, 10, 10,
        05, 20, 05, 10, 05, 15, 10, 10, 05, 15, 20, 10, 10, 15, 10, 10, 10, 10, 10, 10,
        10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 05, 10, 15, 10, 15,
        05, 05, 05, 10, 15, 40, 10, 10, 10, 15, 10, 10, 10, 10, 05, 05, 05, 10, 05, 20,
        10, 10, 05, 20, 20, 10, 10, 05, 05, 05, 40, 10, 20, 10, 10, 10, 10, 05, 05, 15,
        05, 10, 10, 10, 05, 05, 35, 15, 10, 10, 15, 05, 10, 10, 10, 05, 05, 10, 05, 15,
        10, 15, 10, 15, 15, 15, 05, 05, 05, 10, 10,
    };

    /// <summary>
    /// Bitflag indexes of moves that are not usable in game.
    /// </summary>
    /// <remarks>
    /// This is a bitflag array, where each bit represents a move. If the bit is set, the move is not usable in game.
    /// Instead of allocating a hashset, this is a more efficient method (no allocation) with O(1) lookup (faster than HashSet's O(1) lookup).
    /// </remarks>
    public static ReadOnlySpan<byte> DummiedMoves => new byte[] // 673 moves (1346 bytes) => 104 bytes.
    {
        0x7E, 0xBC, 0xFE, 0xFF, 0xBD, 0xEA, 0xCF, 0x72, 0x7F, 0x1F,
        0x0E, 0x1F, 0xAB, 0xFD, 0xEF, 0xBE, 0x7D, 0xD7, 0x35, 0xCF,
        0xD5, 0xEF, 0x5F, 0x0F, 0xEF, 0x9E, 0xFD, 0xFF, 0x7E, 0x5F,
        0x3B, 0xFD, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF, 0xBF, 0xB3,
        0xBF, 0xAF, 0xF5, 0xE4, 0xF6, 0xFF, 0xFB, 0xFF, 0xFF, 0x2B,
        0x84, 0x8C, 0x08, 0xA0, 0xDB, 0xAA, 0xC5, 0x21, 0xF0, 0xFB,
        0xFF, 0xF7, 0xFF, 0xFB, 0xFF, 0xF3, 0xFE, 0xBF, 0xFF, 0xE7,
        0xFF, 0xFF, 0x7D, 0xFC, 0xF7, 0xDF, 0xFE, 0xFF, 0xFF, 0xFF,
        0xFF, 0xFF, 0xFF, 0xB7, 0xFF, 0xFF, 0xFF, 0xFF, 0xBF, 0xFF,
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xEF,
        0xFF, 0xFF, 0xFF, 0x07,
    };
    public static ReadOnlySpan<byte> MoveAccuracy_LA => new byte[]
    {
        100,100,100,85,85,85,100,100,100,100,100,100,30,100,101,95,100,100,101,95,85,75,100,100,100,75,95,85,100,100,100,85,30,100,100,90,85,100,100,100,100,100,100,100,100,100,101,55,55,90,100,100,100,100,101,100,85,100,100,75,100,100,100,90,100,100,80,100,100,100,100,100,100,90,101,95,100,80,80,80,85,95,100,85,100,100,90,75,90,100,30,100,90,100,100,70,101,101,100,100,101,100,101,85,101,101,101,101,100,100,101,101,101,101,101,101,101,101,101,101,100,75,100,70,100,85,85,100,85,101,100,100,100,101,80,101,90,100,100,90,85,100,75,90,101,100,100,100,100,100,101,101,90,100,80,90,101,90,90,101,101,100,90,100,101,101,101,90,100,101,101,100,100,100,101,100,101,95,100,100,100,100,101,100,100,101,75,101,100,100,85,100,50,101,101,101,95,101,90,101,85,101,100,101,100,90,100,85,101,100,95,90,101,100,101,101,100,90,100,101,101,95,100,50,85,100,101,100,100,100,100,75,95,101,101,101,101,100,80,100,101,101,100,100,101,100,100,100,100,100,85,100,100,100,101,100,101,90,101,100,100,85,100,100,100,100,101,101,101,100,101,100,101,101,101,101,100,101,101,100,100,101,100,100,100,101,101,101,101,101,100,100,100,101,101,100,100,100,100,90,101,90,100,101,100,100,95,90,90,90,100,100,101,100,95,90,101,95,100,85,55,100,101,100,100,101,100,90,85,30,85,100,101,100,101,101,101,100,90,101,85,95,100,100,100,101,101,101,100,101,90,101,101,100,90,101,101,101,100,90,100,101,100,100,100,100,101,101,100,100,100,100,100,100,100,100,101,100,100,101,100,101,101,101,101,101,100,100,100,100,101,101,101,101,100,100,101,101,100,101,100,90,100,95,100,100,101,75,100,100,100,70,100,100,100,100,90,101,100,100,100,100,95,95,95,100,85,100,90,85,100,85,101,101,90,100,100,90,85,90,100,80,100,101,80,100,100,100,100,100,100,90,100,100,100,101,101,80,101,90,95,101,100,75,90,85,100,100,101,101,101,101,101,100,100,101,101,101,101,100,100,100,100,101,100,100,100,100,100,101,100,100,100,100,100,101,100,100,100,101,100,101,101,100,101,101,100,100,101,90,100,100,100,101,100,100,101,50,100,100,100,100,100,100,90,90,101,95,100,95,90,100,100,100,95,100,90,100,101,95,100,85,75,100,85,100,100,100,100,95,85,85,100,90,90,100,90,95,100,100,95,101,90,101,101,100,100,100,100,101,100,100,100,100,101,100,101,100,101,101,101,101,101,90,100,100,100,101,101,101,101,95,95,101,100,100,101,101,100,100,100,101,101,101,101,100,101,101,100,100,100,100,100,100,100,100,100,90,85,85,100,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,100,101,100,100,100,90,101,95,100,100,100,101,100,101,101,100,100,100,101,100,100,100,100,101,101,101,100,100,100,101,100,100,100,100,101,101,101,101,101,101,101,101,101,101,100,90,100,100,100,100,100,100,100,100,100,101,100,90,100,101,100,100,100,101,101,101,101,101,101,100,100,95,101,100,100,100,95,95,90,90,85,101,100,101,100,100,100,101,101,100,100,100,101,100,100,100,100,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,101,100,100,101,100,100,90,100,100,100,100,100,100,100,100,100,95,101,100,101,100,90,95,100,100,90,90,100,100,100,100,100,90,100,100,100,100,101,100,90,90,100,101,100,100,90,100,100,100,100,100,100,100,100,90,101,90,80,90,85,100,95,85,101,100,100,90,100,101,100,100,90,80,80,80,101,101
    };
    public static ReadOnlySpan<byte> MoveCategory_LA => new byte[]
    {
        01,01,01,01,01,01,01,01,01,01,01,01,01,02,00,01,02,01,00,01,01,01,01,01,01,01,01,01,00,01,01,01,01,01,01,01,01,01,01,00,01,01,01,00,01,00,00,00,00,02,00,02,02,02,00,02,02,02,02,02,02,02,02,02,01,01,01,01,01,01,01,02,02,00,00,01,02,00,00,00,02,00,02,02,02,02,00,02,01,01,01,01,00,02,02,00,00,00,01,01,00,02,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,00,00,01,01,01,02,02,01,02,01,01,02,01,01,01,00,00,00,01,00,02,00,01,01,00,01,00,02,01,00,00,02,00,00,01,01,01,01,00,01,01,00,00,02,01,01,00,01,00,01,01,00,00,00,01,02,00,01,00,02,00,01,00,02,00,01,00,01,00,00,02,02,02,01,02,00,00,00,02,00,01,00,01,00,02,00,00,01,01,00,00,01,01,01,00,00,00,00,01,01,01,00,00,01,01,01,01,02,00,00,01,01,00,01,01,01,00,00,00,02,01,02,00,00,01,02,00,01,02,02,02,01,02,01,01,02,00,02,00,02,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,01,00,00,01,01,00,01,01,02,00,00,00,00,00,01,01,01,00,00,02,02,00,00,01,00,01,01,00,02,01,01,02,02,01,01,02,00,00,02,02,00,01,02,00,00,00,00,02,02,01,02,01,01,02,02,01,01,01,00,00,00,01,02,00,01,02,01,01,01,02,00,00,01,00,01,02,02,02,02,00,00,00,01,01,01,00,02,01,01,01,00,00,01,01,01,01,01,00,01,00,02,00,02,00,00,00,00,00,00,00,01,01,00,01,00,00,00,00,01,01,02,00,01,02,01,01,01,02,01,02,02,01,02,01,02,02,02,01,02,00,01,00,01,01,01,01,01,01,01,01,02,01,01,02,02,01,00,00,02,02,02,02,01,01,01,01,01,01,01,00,01,02,02,02,01,02,01,01,01,00,00,01,00,02,02,00,01,02,00,02,02,01,00,00,00,00,00,02,02,00,00,00,00,01,01,02,02,00,01,02,02,00,01,00,01,02,01,00,00,00,02,02,01,02,02,00,00,02,00,00,02,01,00,01,02,00,01,00,01,02,00,02,02,02,02,02,02,01,02,01,00,02,01,01,01,01,01,01,01,01,02,01,00,02,02,01,02,01,01,02,02,02,02,02,01,02,02,01,02,02,01,01,02,01,01,00,02,00,00,01,01,00,00,00,02,00,01,02,02,00,00,02,00,00,00,00,00,01,02,02,02,00,00,00,00,01,02,02,02,02,00,00,00,00,00,00,00,00,00,02,00,00,00,01,01,02,01,02,01,01,01,02,02,01,01,01,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,02,01,00,01,00,01,01,02,01,00,01,00,01,01,00,00,00,00,01,02,01,00,01,01,01,02,00,01,00,02,02,01,00,01,02,01,01,00,01,01,02,02,01,02,01,00,02,02,02,01,01,01,01,01,02,01,01,02,00,01,02,01,02,02,01,02,02,01,02,01,01,02,01,02,01,02,02,02,01,02,02,01,02,02,01,01,00,02,02,01,00,00,00,00,01,00,00,01,01,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,01,00,01,01,01,01,01,01,01,01,02,02,01,01,02,00,00,01,01,02,02,02,01,01,02,02,02,01,02,02,01,02,01,01,02,00,01,01,01,02,00,01,01,02,02,02,02,01,01,02,02,01,01,00,01,02,02,01,01,02,01,00,01,01,02,02,00,01,02,01,02,02,02,00,00
    };
    public static ReadOnlySpan<byte> MovePower_LA => new byte[]
    {
        40,40,50,15,18,80,40,75,75,75,40,55,01,80,00,50,40,60,00,90,15,80,45,65,30,120,100,60,00,70,65,15,01,40,85,15,90,120,100,00,30,25,40,00,60,00,00,00,00,01,00,40,40,80,00,40,100,90,80,100,65,65,65,120,35,80,80,01,01,01,80,30,40,00,00,55,120,00,00,00,90,00,01,35,40,80,00,100,50,100,01,80,00,50,80,00,00,00,40,20,00,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,00,00,150,100,30,30,65,65,100,80,35,60,130,20,10,00,00,00,130,00,100,00,15,75,00,140,00,40,70,00,00,01,00,00,100,250,18,50,00,75,80,00,00,80,01,70,00,50,00,10,60,00,00,00,60,50,00,01,00,100,00,01,00,40,00,40,00,60,00,00,80,30,65,40,120,00,00,00,60,00,25,00,90,00,75,00,00,40,40,00,00,65,40,70,00,00,00,00,01,01,01,00,00,100,01,100,100,60,00,00,40,50,00,100,50,70,00,00,00,50,100,40,00,00,80,01,00,80,60,80,120,40,35,01,40,90,00,01,00,95,00,00,00,00,00,70,150,70,00,00,00,00,00,00,00,00,00,00,120,00,00,60,75,00,65,01,150,00,00,00,00,00,70,80,15,00,00,70,70,00,00,85,00,40,60,00,90,50,75,150,150,90,30,50,00,00,60,110,00,60,60,00,00,00,00,150,75,60,70,85,35,01,90,25,60,25,00,00,00,80,150,00,85,55,50,60,120,60,00,00,85,00,25,60,60,140,140,00,00,00,70,100,01,00,65,01,30,60,00,00,01,70,100,50,60,00,01,00,01,00,01,00,00,00,01,00,00,00,01,140,00,70,00,00,00,00,100,60,80,00,80,80,70,85,80,75,80,80,80,100,80,75,40,120,80,100,80,00,120,00,40,60,40,70,65,65,65,40,65,70,80,65,80,90,00,00,110,80,80,110,120,150,70,120,80,60,100,00,40,01,65,100,60,50,100,40,90,00,00,120,00,120,90,00,100,90,00,100,60,100,00,00,00,00,00,80,65,00,00,00,00,50,60,70,95,00,01,120,01,00,50,00,65,40,95,00,00,00,60,40,70,50,20,00,00,80,00,00,65,60,00,60,60,00,55,00,70,01,00,100,80,80,80,70,40,60,60,60,00,55,85,80,40,60,75,90,75,01,65,65,00,85,100,25,100,120,50,100,120,75,85,65,130,130,80,140,140,60,80,180,100,100,100,00,120,00,00,50,90,00,00,00,65,00,90,70,40,00,00,50,00,00,00,00,00,85,40,85,140,00,00,00,00,100,110,80,15,70,00,00,00,00,00,00,00,00,00,75,00,00,00,20,40,20,40,80,90,90,90,140,110,120,120,100,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,210,00,90,00,80,85,90,100,00,85,00,125,40,00,00,00,00,80,90,80,00,80,80,20,130,00,70,00,90,100,70,00,100,110,90,60,00,180,180,195,01,195,175,210,00,185,150,130,85,75,85,40,80,160,90,100,100,00,80,01,120,195,150,100,100,200,200,200,190,190,185,80,90,90,01,60,60,60,80,80,100,100,120,01,60,00,100,80,80,00,00,00,00,50,00,00,85,85,00,100,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,00,80,00,80,35,120,100,100,110,60,40,80,80,80,75,90,00,00,80,150,160,120,85,130,30,120,90,120,70,70,50,80,100,150,120,20,00,70,10,40,80,00,80,25,80,150,90,90,90,120,120,110,60,70,00,65,95,70,90,75,120,100,00,100,60,75,60,00,50,60,65,95,95,95,00,00
    };
}
