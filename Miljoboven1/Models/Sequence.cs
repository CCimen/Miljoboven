namespace Miljoboven3.Models;

/*
 * @Id = är det numret som ges av databasen automatisk, vilket bara kommer att vara 1. 
 * @CurrentValue håller i det löpnummer som ska användas för att skapa referensnumret till ärendet.  
 */
public class Sequence
{
    public int Id { get; set; }
    public int CurrentValue { get; set; }
}