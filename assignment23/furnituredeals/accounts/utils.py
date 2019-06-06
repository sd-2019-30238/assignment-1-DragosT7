from django.shortcuts import render, redirect
from django.contrib.auth import login

class SignUpRequest:
    def __init__(self, request, form, mail):
        self.request = request
        self.form = form
        self.mail = mail

    def getRequest(self):
        return self.request

    def getForm(self):
        return self.form

    def getMail(self):
        return self.mail


class SignUpRequestHandler:
    def handle(self, requestObject):
        if requestObject.getForm().is_valid():
            user = requestObject.getForm().save(commit=False)
            user.email = requestObject.getMail()
            user.save()
            login(requestObject.getRequest(), user)
            return redirect('furnitures:list')
        else:
            return render(requestObject.getRequest(), 'accounts/signup.html', {'form': requestObject.getForm()})

handlerDictionary = {"SignUpRequest": SignUpRequestHandler}

class Mediator:
    def mediate(self, reqObj):
        return handlerDictionary[reqObj.__class__.__name__]().handle(reqObj)