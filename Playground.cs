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
      // do something here
      sapModel.CoordSys.SetCoordSys("newSystem", 0, 0, 0, 45, 0, 0);
    }
  }
}