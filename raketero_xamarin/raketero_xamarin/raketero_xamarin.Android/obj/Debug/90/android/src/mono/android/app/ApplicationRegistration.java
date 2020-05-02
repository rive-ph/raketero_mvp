package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("raketero_xamarin.Droid.Application, raketero_xamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", md53d652723f2753b2d6c6f73dab15efe34.Application.class, md53d652723f2753b2d6c6f73dab15efe34.Application.__md_methods);
		mono.android.Runtime.register ("Caliburn.Micro.CaliburnApplication, Caliburn.Micro.Platform, Version=3.2.0.0, Culture=neutral, PublicKeyToken=null", md5f20ebb4511ee386c314084eca6bcca06.CaliburnApplication.class, md5f20ebb4511ee386c314084eca6bcca06.CaliburnApplication.__md_methods);
		
	}
}
