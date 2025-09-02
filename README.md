# show-drop-down-menu-on-tapping-a-message-in-Xamarin.Forms.Chat
Describes how to show a drop down menu with options upon tapping a message in Xamarin.Forms.Chat(SfChat)

## Sample

```xaml

    <ResourceDictionary>
            <Style TargetType="sfChat:IncomingMessageAuthorView">
                <Setter Property="ControlTemplate">
                    <Setter.Value>
                        <ControlTemplate>
                            <StackLayout Orientation="Horizontal">
                                <Label Text="{Binding Author.Name}" HorizontalTextAlignment="Start" BackgroundColor="Transparent" BindingContext="{TemplateBinding BindingContext}"/>
                                <Image HorizontalOptions="EndAndExpand" Source="GroupExpander.png" HeightRequest="20" WidthRequest="20">
                                    <Image.GestureRecognizers>
                                        <TapGestureRecognizer Tapped="OnImageTapGestureRecognizerTapped"/>
                                    </Image.GestureRecognizers>
                                </Image>
                            </StackLayout>
                        </ControlTemplate>
                    </Setter.Value>
                </Setter>
            </Style>
    </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.Content>
        <sfPopup:SfPopupLayout x:Name="popupLayout">
            <sfPopup:SfPopupLayout.PopupView>
                <sfPopup:PopupView ShowHeader="False" ShowFooter="False" AutoSizeMode="Both"> 
                    <sfPopup:PopupView.ContentTemplate>
                        <DataTemplate>
                            <StackLayout>
                                <StackLayout.GestureRecognizers>
                                    <TapGestureRecognizer Tapped="OnLabelTapGestureRecognizerTapped"/>
                                </StackLayout.GestureRecognizers>
                                ...
                        </DataTemplate>
                    </sfPopup:PopupView.ContentTemplate>
                </sfPopup:PopupView>
            </sfPopup:SfPopupLayout.PopupView>
            <sfPopup:SfPopupLayout.Content>
                <Grid x:Name="chatGrid">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>

                    <sfChat:SfChat x:Name="sfChat" 
                           Grid.Row="0"
                           AllowMultilineInput="True"
                           Messages="{Binding Messages}"
                           CurrentUser="{Binding CurrentUser}">
                    </sfChat:SfChat>
                </Grid>
            </sfPopup:SfPopupLayout.Content>
        </sfPopup:SfPopupLayout>
    </ContentPage.Content>

Code behind:

        void OnImageTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            popupLayout.ShowAtTouchPoint();
        }

        void OnLabelTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            popupLayout.Dismiss();
        }

```

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
