using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    public class Builder
    {
        /// <summary>
        /// Считает количество рулонов обоев необходимое на комнату.
        /// </summary>
        /// <param name="RoomHeight">На сколько комната высокая</param>
        /// <param name="RoomWidth">На сколько комната широкая</param>
        /// <param name="RoomLength">На сколько комната длинная</param>
        /// <param name="WindowHeight">На сколько высокое окно</param>
        /// <param name="WindowWidth">На сколько широкое окно</param>
        /// <param name="DoorframeHeight">На сколько высокий дверной проём</param>
        /// <param name="DoorframeWidth">На сколько широкий дверной проём</param>
        /// <param name="WallpaperWidth">На сколько широкий рулон обоев</param>
        /// <returns></returns>
        public double PasteWallpaper(double RoomHeight, double RoomWidth, double RoomLength, double WindowHeight, double WindowWidth, double DoorframeHeight, double DoorframeWidth, double WallpaperWidth)
        {
            double RoomSideA = RoomHeight * RoomWidth;
            double RoomSideB = RoomHeight * RoomLength;

            double RoomPerimeter = (RoomSideA + RoomSideB) * 2;

            double WindowPerimeter = WindowHeight * WindowWidth;
            double DoorframePerimeter = DoorframeHeight * DoorframeWidth;

            double FinalRoomPerimeter = RoomPerimeter - (DoorframePerimeter +  WindowPerimeter);
            double WallpaperPerimeter = WallpaperWidth * 10.5;

            return Math.Ceiling(FinalRoomPerimeter / WallpaperPerimeter);
        }

        /// <summary>
        /// Ну типа считает сколько тебе нужно лёна обмазанного маслом для твоего пола.
        /// </summary>
        /// <param name="RoomWidth">Ширина комнаты</param>
        /// <param name="RoomLength">Длина комнаты</param>
        /// <param name="LinoleumWidth">Ширина линолеума</param>
        /// <returns></returns>
        public double LayLinoleum(double RoomWidth, double RoomLength, double LinoleumWidth)
        {
            double FloorSquare = RoomLength * RoomWidth;
            return FloorSquare / LinoleumWidth;
        }

        /// <summary>
        /// Сколько нужно могу краски чтобы покрасить потолок.
        /// </summary>
        /// <param name="RoomWidth">Ширина комнаты</param>
        /// <param name="RoomLength">Длина комнаты</param>
        /// <param name="PaintConsumption">Потребление краски на квадратный метр</param>
        /// <param name="CanVolume">Объём банок с краской</param>
        /// <returns></returns>
        public double CeilingPainting(double RoomWidth, double RoomLength, double PaintConsumption, double CanVolume)
        {
            double CeilingSquare = RoomLength * RoomWidth;
            double PaintCansNeeded = CeilingSquare / PaintConsumption;
            double PaintCansRequired = PaintCansNeeded / CanVolume;
            return Math.Ceiling(PaintCansRequired);
        }
    }
}
