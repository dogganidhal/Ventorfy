using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventorfy.UserInterface.MVP
{
	public interface IPresenter<TView>
	{
	
		void SetView(TView view);

	}
}
