<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regist.aspx.cs" Inherits="MultiApp.TestApp.View.Regist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ログイン画面</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>項目を入力して下さい</div>
        <div>
            名前<asp:TextBox ID="UserName" runat="server" TextMode="SingleLine" ></asp:TextBox><br />
            <asp:Label ID="UserNameError" runat="server"></asp:Label>
        </div>
        <div>
            生年月日<asp:TextBox ID="birthdayYYYY" runat="server" TextMode="SingleLine"></asp:TextBox>年
                    <asp:TextBox ID="birthdayMM" runat="server"></asp:TextBox>月
                    <asp:TextBox ID="birthdayDD" runat="server"></asp:TextBox>日<br />
            <asp:Label ID="BirthdayError" runat="server"></asp:Label>
        </div>
        <div>
            住所<asp:TextBox ID="Address" runat="server"></asp:TextBox><br />
            <asp:Label ID="AddressError" runat="server"></asp:Label>
        </div>
        <div>
            性別<asp:CheckBox ID="Man" runat="server" Text="男" GroupName="Gender"/>
                <asp:CheckBox ID="Woman" runat="server" Text="女" GroupName="Gender"/><br />
                <asp:Label ID="GenderError" runat="server"></asp:Label>
        </div>
        <div>
            メールアドレス<asp:TextBox ID="mail" runat="server" TextMode="SingleLine"></asp:TextBox><br />
            <asp:Label ID="mailError" runat="server"></asp:Label>
        </div>
        <div>
            パスワード<asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Label ID="PasswordError" runat="server"></asp:Label><br />
            パスワード (確認用)<asp:TextBox ID="PasswordCheck" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Label ID="PasswordCheckError" runat="server"></asp:Label>
        </div>
        <div>
            プロフィール<br />
            <asp:TextBox ID="profile" runat="server" TextMode="MultiLine"
                 Rows="8" Columns="30"></asp:TextBox>
        </div>
        <div>
            画像<br />
            <asp:FileUpload ID="Image" runat="server"/><br />
            <asp:Label ID="ImageError" runat="server"></asp:Label>
        </div>
        <asp:Button ID="checkButton" runat="server" Text="送信"/>
    </form>
</body>
</html>
