using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_20
{
    public static class Solver
    {
        public static long Part1(IEnumerable<Tile> tiles)
        {
            return GetCornerTileIds(tiles.SelectMany(TileOperations.Variations)).Aggregate(1L, (x, y) => x * y);
        }

        public static long Part2(IEnumerable<Tile> tiles)
        {
            var image = CreateImageTile(tiles);
            
            return 0;
        }

        public static Tile CreateImageTile(IEnumerable<Tile> tiles)
        {
            var imageTiles = FindImageTiles(tiles);
            var imageTilesSize = imageTiles.GetLength(0);

            var tileSize = imageTiles[0, 0].Size;
            
            var imageSize = imageTilesSize * (tileSize - 2);
            var image = new bool[imageSize, imageSize];

            for (var tileY = 0; tileY < imageTilesSize; tileY++)
            {
                for (var tileX = 0; tileX < imageTilesSize; tileX++)
                {
                    var imageTile = imageTiles[tileX, tileY];
                    for (var y = 1; y < tileSize - 1; y++)
                    {
                        for (var x = 1; x < tileSize - 1; x++)
                        {
                            image[tileX * (tileSize - 2) + x - 1, tileY * (tileSize - 2) + y - 1] = imageTile.GetCell(x, y);
                        }
                    }
                }
            }

            return new Tile(0, image);
        }
        
        private static Tile[,] FindImageTiles(IEnumerable<Tile> source)
        {
            var tiles = source.SelectMany(TileOperations.Variations).ToList();
            var hashesUsage = tiles
                .SelectMany(tile => new[] {tile.Left, tile.Right, tile.Top, tile.Bottom})
                .GroupBy(hash => hash)
                .ToDictionary(group => group.Key, group => group.Count());

            // select any corner tile to be top-left
            // we can select any because final image can be flipped rotated so chosen tile become top-left
            var topLeftTileId = GetCornerTileIds(tiles)
                .Select(id => tiles.First(tile => tile.Id == id))
                .First()
                .Id;
            
            // need to find proper variation of corner tile
            // so it left and top border hashes be unique (4 uses in all variants)
            // there are 2 such tiles (normal + flipped and rotated so top-left become left-top)
            // so take only one
            var topLeftTile = tiles
                .Where(tile => tile.Id == topLeftTileId)
                .First(tile => hashesUsage[tile.Top] == 4 && hashesUsage[tile.Left] == 4);

            var imageSize = (int) Math.Sqrt(tiles.Count >> 3);
            var image = new Tile[imageSize, imageSize];

            // start from top left and fill top row in image
            // each next tile must have its left border equal to current tile's right border 
            var current = topLeftTile; 
            for (var x = 0; x < imageSize; x++)
            {
                image[x, 0] = current;
                tiles.RemoveAll(tile => tile.Id == current.Id);

                // stop at last column
                if (x == imageSize - 1)
                    break;
                
                var rightVariants = tiles.Where(tile => tile.Left == current.Right).ToList();
                if (rightVariants.Count != 1)
                    throw new Exception("Do not work for multi variant situations");
                current = rightVariants.First();
            }

            // fill each column starting from already filled top row
            for (var x = 0; x < imageSize; x++)
            {
                current = image[x, 0];
                for (var y = 0; y < imageSize; y++)
                {
                    image[x, y] = current;
                    tiles.RemoveAll(tile => tile.Id == current.Id);

                    if (y == imageSize - 1)
                        break;
                    
                    var bottomVariants = tiles.Where(tile => tile.Top == current.Bottom).ToList();
                    if (bottomVariants.Count != 1)
                        throw new Exception("Do not work for multi variant situations");
                    current = bottomVariants.First();
                }
            }

            return image;
        }
        
        private static IEnumerable<int> GetCornerTileIds(IEnumerable<Tile> tilesVariations)
        {
            // all possible (tile id, border hash) variations
            var pairs = new List<(int id, int hash)>();
            foreach (var tile in tilesVariations)
            {
                pairs.Add((tile.Id, tile.Left));
                pairs.Add((tile.Id, tile.Right));
                pairs.Add((tile.Id, tile.Top));
                pairs.Add((tile.Id, tile.Bottom));
            }
            
            // exclude repeats
            pairs = pairs.Distinct().ToList();
            
            // tiles with hashes that appear only once (corner and border tiles)
            var cornerAndBorderPairs = pairs
                .Distinct()
                .GroupBy(pair => pair.hash)
                .Where(group => group.Count() == 1)
                .Select(group => group.First());
            
            // corner tiles (have 4 different hashes, each side was at border)
            return cornerAndBorderPairs
                .GroupBy(pair => pair.id)
                .Where(group => group.Count() == 4)
                .Select(group => group.Key)
                .ToList();
        }
    }
}