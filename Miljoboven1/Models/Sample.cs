namespace Miljoboven3.Models;

/*
 * @SampleId = är det numret som filen får (automatiskt av EF),
 * @SampleName = är namnet på filen,
 * @ErrandID = vilket ärende denna fil är kopplad till.
 */
public class Sample
{
    public int SampleId { get; set; }
    public string SampleName { get; set; }
    public int ErrandId { get; set; }
}