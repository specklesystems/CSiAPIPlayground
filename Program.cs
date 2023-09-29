using System;
using CSiAPIv1;

namespace CSiAPIPlayground
{
  class Program
  {
    private const string ProgID_SAP2000 = "CSI.SAP2000.API.SapObject";
    private const string ProgID_ETABS = "CSI.ETABS.API.ETABSObject";
    private const string ProgID_CSiBridge = "CSI.CSiBridge.API.SapObject";
    private const string ProgID_SAFE = "CSI.SAFE.API.SAFEObject";

    static void Main(string[] _)
    {
      var apiObj = GetActiveAPIObject(new Helper());
      var playground = new Playground(apiObj.SapModel);
      playground.Play();
    }

    private static cOAPI GetActiveAPIObject(Helper helper)
    {
      if (helper.GetObject(ProgID_ETABS) is cOAPI etabsModel)
      {
        return etabsModel;
      }
      else if (helper.GetObject(ProgID_SAP2000) is cOAPI sapModel)
      {
        return sapModel;
      }
      else if (helper.GetObject(ProgID_SAFE) is cOAPI safeModel)
      {
        return safeModel;
      }
      else if (helper.GetObject(ProgID_CSiBridge) is cOAPI bridgeModel)
      {
        return bridgeModel;
      }
      throw new Exception("Unable to find running instance of csi application :(");
    }
  }
}
