# REBAR WEIGHT TOOL
Tool help 西山 team of エマール group calculate 重量 of 鉄筋 from 文化シャッター partner.

## IMAGE DEMO
<p align="center">
<img src="https://raw.githubusercontent.com/Tynab/Rebar-Weight/main/pic/0.jpg"></img>
</p>

## CODE DEMO
```vb
''' <summary>
''' Check update.
''' </summary>
Friend Sub ChkUpd()
    If IsNetAvail() AndAlso Not (New WebClient).DownloadString(My.Resources.link_ver).Contains(My.Resources.app_ver) Then
        MsgBox($"「{My.Resources.app_true_name}」新しいバージョンが利用可能！", 262144, Title:="更新")
        Dim frmUpd = New FrmUpdate
        frmUpd.ShowDialog()
    End If
End Sub
```

### PACKAGES
<img src="https://raw.githubusercontent.com/Tynab/Rebar-Weight/main/pic/1.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Tynab.YANF » 1.0.1

</div>