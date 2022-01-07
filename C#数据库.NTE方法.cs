using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace     //继承于哪个项目
{
    class NET
    {//创建一个类
        SqlConnection CON;
        //声明一个SqlConnection类;

        public SqlConnection Con()
        {//连接方法
            CON = new SqlConnection("server=.;uid=sa;pwd=123456;database=");//数据库名称
            //连接数据库
            CON.Open();
            //打开数据库
            if (CON.State == ConnectionState.Open)
            {
                return CON;
                //返回数据库对象
            }
            else
            {
                CON.Close();
                return CON;
            }
        }

        public SqlCommand Com(string sql)
        {//操作对象
            SqlCommand COM = new SqlCommand(sql, Con());
            //执行命令
            return COM;
            //返回执行结果
        }

        public int Execute(string sql)
        {//更新操作
            return Com(sql).ExecuteNonQuery();
        }

        public SqlDataReader Sdr(string sql)
        {//读取操作
            return Com(sql).ExecuteReader();
        }

        public SqlDataAdapter Sda(string sql)
        {//创建数据适配器
            SqlDataAdapter sda = new SqlDataAdapter(sql, Con());
            //创建数据适配器对象
            DataSet ds = new DataSet();
            //创建虚拟数据库、数据集
            sda.Fill(ds);
            //填充数据集
            return sda;
            //返回数据库执行命令
        }

        public void NETClose()
        {//关闭数据库
            CON.Close();
        }
    }
}
