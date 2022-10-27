namespace Miljoboven3.Models;

/*
 * @PictureId = är det numret som filen får (automatiskt av EF),
 * @PictureName = är namnet på filen,
 * @ErrandID = vilket ärende denna fil är kopplad till.
 */
public class Picture
{
    public int PictureId { get; set; }
    public string PictureName { get; set; }
    public int ErrandId { get; set; }
}