using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorStructural {
	abstract class Iterator {
		public abstract object First();
		public abstract object Next();
		public abstract bool isDone();
		public abstract object CurrentItem();
	}
}