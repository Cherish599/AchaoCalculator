#include <iostream>
#include <vector>
#include <map>
#include <stdlib.h>
#include <time.h>
#include <cstdio>
using namespace std;
const int maxn = 105;
typedef long long ll;
map<int, char>mp;
string opt[maxn];//储存操作符
vector<int>pre[maxn];//储存参与运算的数字
ll qiu(vector<int>& v, string op, int id, int mx)//由于只有简单的运算，这里使用递归解决
{
	if (id == mx)
		return v[id];
	ll now = v[id];
	for (int i = id; i < mx; ++i)
	{
		if (op[i] == '*')
		{
			now *= v[i + 1];
		}
		else if (op[i] == '/')
		{
			if (now % v[i + 1] == 0)//判断是否出现小数
				now /= v[i + 1];
			else
				return -1e15;//如果出现小数则返回-1e15，便于最后比较结果
		}
		else if (op[i] == '+' && (i + 1 < mx && (op[i + 1] == '/' || op[i + 1] == '*')))
		{
			int tmp = qiu(v, op, i + 1, mx);//根据运算符优先级进行递归
			now += tmp;
			return now;
		}
		else if (op[i] == '+')
		{
			now += v[i + 1];
		}
		else if (op[i] == '-' && (i + 1 < mx && (op[i + 1] == '/' || op[i + 1] == '*')))
		{
			int tmp = qiu(v, op, i + 1, mx);
			now -= tmp;
			return now;
		}
		else
		{
			now -= v[i + 1];
		}
	}
	return now;
}
int main()//1*2-3+4*5
{
	FILE* stream;
	mp[1] = '+';
	mp[2] = '-';
	mp[3] = '*';
	mp[4] = '/';//使用map使编码简洁
	srand((unsigned)time(NULL));//用时间作为随机种子取随机数
	cout << "请输入问题个数:" << endl;
	freopen_s(&stream,"subject.txt", "w", stdout);//输出到文件
	int n;
	cin >> n;
	cout << "以下为" << n << "个四则运算式" << endl;
	for (int i = 1; i <= n; ++i)
	{
		bool ok = false;
		while (!ok)//不断进行随机操作直到满足条件
		{
			opt[i].clear();
			pre[i].clear();//清空
			int optnumber = rand() % 2 + 2;//运算符个数
			for (int j = 1; j <= optnumber; ++j)
			{
				int tmp = rand() % 4 + 1;
				opt[i] += mp[tmp];
			}
			for (int j = 1; j <= optnumber + 1; ++j)
			{
				int tmp = rand() % 101;
				pre[i].push_back(tmp);
			}
			ll res = qiu(pre[i], opt[i], 0, optnumber);
			if (res >= 0 && res < 1e9) {//满足条件输出运算式
				ok = true;
				for (int j = 0; j < pre[i].size(); ++j)
				{
					cout << pre[i][j];
					if (j != pre[i].size() - 1)
						cout << opt[i][j];
				}
				cout << "=" << res << endl;
			}
		}
	}
	fclose(stdout);
	return 0;
}
