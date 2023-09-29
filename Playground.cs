using CSiAPIv1;

namespace CSiAPIPlayground
{
  public class Playground
  {
    private readonly cSapModel sapModel;

    public Playground(cSapModel sapModel)
    {
      this.sapModel = sapModel;
    }

    public void Play()
    {
      // do something with the sapModel here.
      // note that the object is called sapModel, but this is just copying the CSi convention.
      // this object is valid for any other CSi program such as ETABS.
    }
  }
}