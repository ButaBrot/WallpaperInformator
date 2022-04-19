using WallpaperInformator.DataAccess.Entities;

namespace WallpaperInformator.DataAccess;

public abstract class Repository<T> where T: Entity
{
   protected string _apiKey ="947aa21a922735ee70e68970da5aebc7";
   protected Uri _baseAdress;
   

    protected virtual void ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(_apiKey))
        {
            throw new ArgumentException("An apiKey has to be provided");
        }
        if (string.IsNullOrWhiteSpace(_baseAdress.AbsoluteUri)&&_baseAdress.AbsoluteUri.Length>6)
        {
            throw new ArgumentException("A BaseAdress has to be provided");
        }
        
    }
  
    
}