using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// projClass 的摘要说明
/// </summary>
public class projClass
{
	public projClass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public int getUsers(string stuId, string userPwd)
    //判断用户名和密码是否正确,不过没有使用,后来用得是下面的getUser.(里面用到存储过程)
    //cost:武海涛
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand thisCommand = new SqlCommand("select stuId from student where stuId='" + stuId + "'and stuPwd='" + userPwd + "'", myConnection);

        myConnection.Open();
        SqlDataReader thisReader = thisCommand.ExecuteReader();
        int count = 0;
        if (thisReader.Read())
        {
            count = 1;

        }

        thisReader.Close();
        myConnection.Close();
        return count;

    }
    public int ifStuExist(string stuId)
    //判断是否存在此学生!
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_selectAsId", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            thisReader.Close();
            return 1;
        }
        else
            thisReader.Close();
        return 0;
    }
    public int ifCourseExist(string courseId, string courseName)
    //判断是否存在此课程!
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_course_ifExist", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myCommand.Parameters.Add("@courseName", SqlDbType.VarChar, 20).Value = courseName;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            thisReader.Close();
            return 1;
        }
        else
            thisReader.Close();
        return 0;
    }
    public int ifteacherExist(string teacherId)
    //判断是否存在此课程!
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_selectInfo", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@teacherId", SqlDbType.VarChar, 15).Value = teacherId;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            thisReader.Close();
            return 1;
        }
        else
            thisReader.Close();
        return 0;
    }
    public int ifTeacherExist(string teacherId)
    //判断是否存在此教师
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_selectInfo", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@teacherId", SqlDbType.VarChar, 15).Value = teacherId;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            thisReader.Close();
            return 1;
        }
        else
            thisReader.Close();
        return 0;
    }
    public int getUser(string stuId, string stuPwd)
    //判断用户名和密码是否正确
    //cost:武海涛
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_select", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myCommand.Parameters.Add("@stuPwd", SqlDbType.VarChar, 10).Value = stuPwd;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();

        //int count=0;//count=0说明用户名不存在
        if (thisReader.Read())
        {
            return 1;

        }
        thisReader.Close();
        myConnection.Close();
        return 0;

    }
    public DataSet getStuInfoAsId(string stuId)
    //根据学生的学号来查找学生
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_selectAsId", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myConnection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
        DataSet ds = new DataSet();
        adapter.Fill(ds, "stuInfo");
        myConnection.Close();
        return ds;
    }
    public DataSet getStuInfoAsStatus(int stuStatus)
    //根据学生的状态查找学生记录
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_selectAsStatus", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuStatus", SqlDbType.Int).Value = stuStatus;
        myConnection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
        DataSet ds = new DataSet();
        adapter.Fill(ds, "stuInfo");
        myConnection.Close();
        return ds;
    }

    public int getAdmin(string adminId, string adminPwd)
    //判断用户名和密码是否正确
    //cost:武海涛
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_administrator_select", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@adminId", SqlDbType.VarChar, 15).Value = adminId;
        myCommand.Parameters.Add("@adminPwd", SqlDbType.VarChar, 10).Value = adminPwd;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();

        int count = 0;
        if (thisReader.Read())
        {
            count = 1;

        }

        thisReader.Close();
        myConnection.Close();
        return count;

    }
    public int getTeacher(string teacherId, string teacherPwd)
    //判断用户名和密码是否正确
    //cost:武海涛
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_select", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@teacherId", SqlDbType.VarChar, 15).Value = teacherId;
        myCommand.Parameters.Add("@teacherPwd", SqlDbType.VarChar, 10).Value = teacherPwd;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();

        int count = 0;
        if (thisReader.Read())
        {
            count = 1;

        }

        thisReader.Close();
        myConnection.Close();
        return count;

    }
    public string getUserName(string stuId)
    //从数据库中取得学生的姓名
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_selectName", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            return thisReader[0].ToString();

        }
        else

            return "none";
    }
    public string getTeacherName(string teacherId)
    //从数据库中取得教师的姓名
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_selectInfo", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@teacherId", SqlDbType.VarChar, 15).Value = teacherId;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            return thisReader[2].ToString();

        }
        else

            return "none";
    }
    public string getTeacherCourseId(string teacherId)
    //从数据库中取得教师的所教的科目ID
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_selectInfo", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@teacherId", SqlDbType.VarChar, 15).Value = teacherId;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            return thisReader[3].ToString();

        }
        else

            return "none";
    }
    public string getTeacherIdAsCourseId(string courseId)
    //根据courseId取出老师姓名
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_selectAsCourseId", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            return thisReader[0].ToString();

        }
        else

            return "none";
    }
    public bool getIfTest(string courseId)
    //判断该科目是否可以考试
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_course_isTest_select", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            return thisReader.GetBoolean(0);

        }
        else

            return false;
    }
    public DataSet getCourses()
    //从数据库的course表中取得课程信息,从而绑定到页面的dropdownlist中
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_course_selectCourses", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myConnection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        myConnection.Close();
        return ds;
    }
    public DataSet getTest(string course)
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_test_selectAsCourse", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@testCourse", SqlDbType.VarChar, 20).Value = course;
        myConnection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
        DataSet ds = new DataSet();
        adapter.Fill(ds, "testInfo");
        myConnection.Close();
        return ds;
    }
    public DataSet getQuestionAndAns(string course)
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_test_select_questionAndAns", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@testCourse", SqlDbType.VarChar, 20).Value = course;
        myConnection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        myConnection.Close();
        return ds;
    }
    public DataSet getStuInfo()
    //取得学生的信息
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_selectInfo", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myConnection.Open();
        //	SqlDataReader thisReader=myCommand.ExecuteReader();
        //return thisReader;
        SqlDataAdapter da = new SqlDataAdapter(myCommand);
        DataSet ds = new DataSet();
        da.Fill(ds, "stuInfo");
        myConnection.Close();
        return ds;
    }
    public DataSet getTeacherInfo(string teacherId)
    //取得学生的信息
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_selectInfo", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@teacherId", SqlDbType.VarChar, 10).Value = teacherId;
        myConnection.Open();

        SqlDataAdapter da = new SqlDataAdapter(myCommand);
        DataSet ds = new DataSet();
        da.Fill(ds, "teacherInfo");
        myConnection.Close();
        return ds;
    }
    public DataSet getScoreAsStuIdAndCourseId()
    //取得考试结果的信息
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_score_selectASstuIdAndCourseId", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myConnection.Open();
        //	SqlDataReader thisReader=myCommand.ExecuteReader();
        //return thisReader;
        SqlDataAdapter da = new SqlDataAdapter(myCommand);
        DataSet ds = new DataSet();
        da.Fill(ds, "scoreInfo");
        myConnection.Close();
        return ds;
    }
    public DataSet getTeacherAllInfo()
    //取得考试结果的信息
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_selectAllInfo", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myConnection.Open();
        //	SqlDataReader thisReader=myCommand.ExecuteReader();
        //return thisReader;
        SqlDataAdapter da = new SqlDataAdapter(myCommand);
        DataSet ds = new DataSet();
        da.Fill(ds, "teacherInfo");
        myConnection.Close();
        return ds;
    }
    public int updateStuInfo(string stuId, string stuPwd, string stuName, int stuSex)
    //更新学生信息,返回1表示更新成功,返回0则更新失败
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_update", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myCommand.Parameters.Add("@stuPwd", SqlDbType.VarChar, 10).Value = stuPwd;
        myCommand.Parameters.Add("@stuSex", SqlDbType.Int).Value = stuSex;
        myCommand.Parameters.Add("@stuName", SqlDbType.Char, 10).Value = stuName;
        //myCommand.Parameters.Add("@isTest",SqlDbType.Int,0).Value=stuStatus;
        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }


    }
    public int updateAdminPwd(string adminId, string adminPwd)
    //更新管理员信息,返回1表示更新成功,返回0则更新失败
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_admin_update", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@adminId", SqlDbType.VarChar, 15).Value = adminId;
        myCommand.Parameters.Add("@adminPwd", SqlDbType.VarChar, 10).Value = adminPwd;

        //myCommand.Parameters.Add("@isTest",SqlDbType.Int,0).Value=stuStatus;
        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }


    }
    public int updateTeacherPwd(string teacherId, string teacherPwd)
    //更新教师的密码,返回1表示更新成功,返回0则更新失败
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_update", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@teacherId", SqlDbType.VarChar, 15).Value = teacherId;
        myCommand.Parameters.Add("@teacherPwd", SqlDbType.VarChar, 10).Value = teacherPwd;

        //myCommand.Parameters.Add("@isTest",SqlDbType.Int,0).Value=stuStatus;
        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }


    }
    public int updateTeacherInfo(string teacherId, string teacherPwd, string teacherName, string courseId)
    //更新教师的信息,返回1表示更新成功,返回0则更新失败
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_updateInfo", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@teacherId", SqlDbType.VarChar, 15).Value = teacherId;
        myCommand.Parameters.Add("@teacherPwd", SqlDbType.VarChar, 10).Value = teacherPwd;
        myCommand.Parameters.Add("@teacherName", SqlDbType.VarChar, 10).Value = teacherName;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;

        //myCommand.Parameters.Add("@isTest",SqlDbType.Int,0).Value=stuStatus;
        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }


    }
    public int insertStuStatusToScore(string stuId, string courseId, int courseStatus, int score)
    //在分数表里插入相关记录
    {
        SqlConnection myConnection = BaseClass.DBCon();
        SqlCommand myCommand = new SqlCommand("sp_score_courseStatus_insert", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myCommand.Parameters.Add("@courseStatus", SqlDbType.Int, 0).Value = courseStatus;
        myCommand.Parameters.Add("@score", SqlDbType.Int, 0).Value = score;
        int ifTest = (new projClass()).ifCourseHasTest(stuId, courseId);
        if (ifTest == 0)
        {
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException SQLexc)
            {
                Console.WriteLine("SqlException:{0}", SQLexc);
                return 0;

            }
            finally
            {
                myConnection.Close();
            }
        }
        else return 0;


    }
    public int updateScore(string stuId, string courseId, int courseStatus, int score)
    //在分数表里插入相关记录
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_score_statusUpdate", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myCommand.Parameters.Add("@courseStatus", SqlDbType.Int, 0).Value = courseStatus;
        myCommand.Parameters.Add("@score", SqlDbType.Int, 0).Value = score;
        int ifTest = (new projClass()).ifCourseHasTest(stuId, courseId);

        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }



    }
    public int updateCourseInfo(string courseId, string courseName, bool isTest)
    //更新课程信息,返回1表示更新成功,返回0则更新失败
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_course_update", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myCommand.Parameters.Add("@courseName", SqlDbType.VarChar, 20).Value = courseName;
        myCommand.Parameters.Add("@isTest", SqlDbType.Bit).Value = isTest;
        //myCommand.Parameters.Add("@isTest",SqlDbType.Int,0).Value=stuStatus;
        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }


    }
    public int insertCourseInfo(string courseId, string courseName, bool isTest)
    //向course表中添加记录
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_course_insert", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myCommand.Parameters.Add("@courseName", SqlDbType.VarChar, 20).Value = courseName;
        myCommand.Parameters.Add("@isTest", SqlDbType.Bit).Value = isTest;
        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }

    }
    public int insertAdmin(string adminId, string adminPwd)
    //向管理员表中添加记录
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_admin_insert", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@adminId", SqlDbType.VarChar, 20).Value = adminId;
        myCommand.Parameters.Add("@adminPwd", SqlDbType.VarChar, 20).Value = adminPwd;

        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }

    }
    public int deleteCourseInfo(string courseId)
    //在course表中删除记录,成功返回1,失败返回0
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_course_delete", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;

        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;//删除成功
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;//删除失败

        }
        finally
        {
            myConnection.Close();
        }
    }
    public int deleteScoreInfo(string stuId, string courseId)
    //在course表中删除记录,成功返回1,失败返回0
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_score_delete", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;//删除成功
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;//删除失败

        }
        finally
        {
            myConnection.Close();
        }
    }


    public int insertStuinfo(string stuId, string stuName, string stuPwd, int stuSex, int stuStatus, string courseID)
    //向student表中添加记录
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_insert", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myCommand.Parameters.Add("@stuPwd", SqlDbType.VarChar, 10).Value = stuPwd;
        myCommand.Parameters.Add("@stuName", SqlDbType.Char, 10).Value = stuName;
        myCommand.Parameters.Add("@stuStatus", SqlDbType.Int).Value = stuStatus;
        myCommand.Parameters.Add("@stuSex", SqlDbType.Int).Value = stuSex;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseID;
        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }

    }
    public int insertTeacherinfo(string teacherId, string teacherPwd, string teacherName, string courseID)
    //向student表中添加记录
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_insert", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@teacherId", SqlDbType.VarChar, 15).Value = teacherId;
        myCommand.Parameters.Add("@teacherPwd", SqlDbType.VarChar, 10).Value = teacherPwd;
        myCommand.Parameters.Add("@teacherName", SqlDbType.VarChar, 10).Value = teacherName;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseID;
        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }

    }
    public int getStudentCount()
    //取得数据库中学生的人数
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_getCount", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myConnection.Open();
        int count = (int)myCommand.ExecuteScalar();
        return count;
    }


    public int deleteStuInfo(string stuId)
    //在student表中删除记录,成功返回1,失败返回0
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_delete", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;

        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;//删除成功
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;//删除失败

        }
        finally
        {
            myConnection.Close();
        }

    }
    public int deleteTeacherInfo(string teacherId)
    //在student表中删除记录,成功返回1,失败返回0
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_teacher_delete", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@teacherId", SqlDbType.VarChar, 15).Value = teacherId;

        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;//删除成功
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;//删除失败

        }
        finally
        {
            myConnection.Close();
        }

    }
    public int updateStuStatus(string stuId, string courseId, int status)
    //在学生表里对学生的状态进行修改
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_StatusUpdate", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myCommand.Parameters.Add("@stuStatus", SqlDbType.Int).Value = status;
        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;//成功
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;//失败

        }
        finally
        {
            myConnection.Close();
        }

    }

    public int updateStuPwd(string stuId, string pwd)
    //在学生表里对学生的密码进行修改
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_student_pwdUpdate", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myCommand.Parameters.Add("@stuPwd", SqlDbType.VarChar, 10).Value = pwd;
        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;//成功
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;//失败

        }
        finally
        {
            myConnection.Close();
        }


    }
    public int insertTest(string testContent, string testAns1, string testAns2, string testAns3, string testAns4, int rightAns, int pub, int testScore, string testCourseId)
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_test_insert", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;

        myCommand.Parameters.Add("@testContent", SqlDbType.NVarChar, 100).Value = testContent;
        myCommand.Parameters.Add("@testAns1", SqlDbType.VarChar, 50).Value = testAns1;
        myCommand.Parameters.Add("@testAns2", SqlDbType.VarChar, 50).Value = testAns2;
        myCommand.Parameters.Add("@testAns3", SqlDbType.VarChar, 50).Value = testAns3;
        myCommand.Parameters.Add("@testAns4", SqlDbType.VarChar, 50).Value = testAns4;
        myCommand.Parameters.Add("@rightAns", SqlDbType.Int).Value = rightAns;
        myCommand.Parameters.Add("@pub", SqlDbType.Int).Value = pub;
        myCommand.Parameters.Add("@testScore", SqlDbType.Int).Value = testScore;
        myCommand.Parameters.Add("@testCourseId", SqlDbType.VarChar, 20).Value = testCourseId;

        try
        {
            myConnection.Open();
            int count = myCommand.ExecuteNonQuery();
            return count;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }

    }
    public string getCourseIdAsCourseName(string courseName)
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_course_selectCourseIdAsCourseName", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@courseName", SqlDbType.VarChar, 20).Value = courseName;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            return thisReader.GetString(0);
        }
        else return "none";

    }
    public string getCourseNameAsCourseId(string courseId)
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_course_selectCourseNameAsCourseId", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            return thisReader.GetString(0);
        }
        else return "none";

    }
    public bool getIsTestAsCourseId(string courseId)
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_course_isTest_select", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();
        if (thisReader.Read())
        {
            bool isTest = thisReader.GetBoolean(0);
            return isTest;
        }
        else return false;

    }
    public DataSet getTestInfoAsId(string testId)
    //根据试题ID来获取试题详细信息
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_test_selectAsId", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@testId", SqlDbType.UniqueIdentifier).Value = new Guid(testId);
        myConnection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
        DataSet ds = new DataSet();
        adapter.Fill(ds, "testInfo");
        myConnection.Close();
        return ds;
    }
    public int updateTestInfo(string testId, string testContent, string testAns1, string testAns2, string testAns3, string testAns4, int rightAns, int pub, int testScore, string testCourseId)
    //更新试题信息,返回1表示更新成功,返回0则更新失败
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_test_update", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@testId", SqlDbType.UniqueIdentifier).Value = new Guid(testId);
        myCommand.Parameters.Add("@testContent", SqlDbType.NVarChar, 100).Value = testContent;
        myCommand.Parameters.Add("@testAns1", SqlDbType.VarChar, 50).Value = testAns1;
        myCommand.Parameters.Add("@testAns2", SqlDbType.VarChar, 50).Value = testAns2;
        myCommand.Parameters.Add("@testAns3", SqlDbType.VarChar, 50).Value = testAns3;
        myCommand.Parameters.Add("@testAns4", SqlDbType.VarChar, 50).Value = testAns4;
        myCommand.Parameters.Add("@rightAns", SqlDbType.Int).Value = rightAns;
        myCommand.Parameters.Add("@pub", SqlDbType.Int).Value = pub;
        myCommand.Parameters.Add("@testScore", SqlDbType.Int).Value = testScore;
        myCommand.Parameters.Add("@testCourseId", SqlDbType.VarChar, 20).Value = testCourseId;

        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;

        }
        finally
        {
            myConnection.Close();
        }


    }
    public int deleteTestInfo(string testId)
    //在test表中删除记录,成功返回1,失败返回0
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_test_delete", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@testId", SqlDbType.UniqueIdentifier).Value = new Guid(testId);

        try
        {
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            return 1;//删除成功
        }
        catch (SqlException SQLexc)
        {
            Console.WriteLine("SqlException:{0}", SQLexc);
            return 0;//删除失败

        }
        finally
        {
            myConnection.Close();
        }

    }

    public SqlDataReader createTest(string courseId)
    {
        SqlConnection myConnection = BaseClass.DBCon();
        SqlCommand myCommand = new SqlCommand("sp_test_create", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 20).Value = courseId;
        myConnection.Open();
        SqlDataReader reader = myCommand.ExecuteReader();
        return reader;
    }

    public int ifCourseHasTest(string stuId, string courseId)
    //判断指定的用户指定的科目是否已经考试过
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_score_courseStatus_select", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myCommand.Parameters.Add("@courseId", SqlDbType.VarChar, 10).Value = courseId;
        myConnection.Open();
        SqlDataReader thisReader = myCommand.ExecuteReader();


        if (thisReader.Read())
        {
            return 1;//说明找到了记录,即用户已经考试过了.

        }
        thisReader.Close();
        myConnection.Close();
        return 0;

    }
    public int getRightAnsAsTestId(string testId)
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_test_rightAnsselectAsId", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@testId", SqlDbType.UniqueIdentifier).Value = new Guid(testId);
        myConnection.Open();
        SqlDataReader reader = myCommand.ExecuteReader();
        int rightAns = 1;
        if (reader.Read())
        {
            rightAns = reader.GetInt32(0);
        }
        reader.Close();
        return rightAns;
    }
    public DataSet getStuScore(string stuId)
    //取得学生考试结果的信息
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["strConn"]);
        SqlCommand myCommand = new SqlCommand("sp_score_select", myConnection);
        myCommand.CommandType = CommandType.StoredProcedure;
        myCommand.Parameters.Add("@stuId", SqlDbType.VarChar, 15).Value = stuId;
        myConnection.Open();

        SqlDataAdapter da = new SqlDataAdapter(myCommand);
        DataSet ds = new DataSet();
        da.Fill(ds, "stuInfo");
        myConnection.Close();
        return ds;
    }
}
