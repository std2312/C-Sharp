using System;

namespace QQClass
{
	/// <summary>
	/// ClassUser ��ժҪ˵����
	/// </summary>
	[Serializable] 
	public class ClassUsers: System.Collections.CollectionBase 
	{
		public ClassUsers()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		public void add(ClassUserInfo userInfo)
		{
			base.InnerList.Add(userInfo);
		}

		public void Romove(ClassUserInfo userInfo)
		{
			base.InnerList.Remove (userInfo);
		}

        public ClassUserInfo this[int index]
        {
            get
            {
                return ((ClassUserInfo)List[index]);
            }
            set
            {
                List[index] = value;
            }
        }
	}
}
