# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2019-07-18 19:01
from __future__ import unicode_literals

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('book_reviews', '0002_remove_book_uploaded_by'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='book',
            name='users_who_like',
        ),
    ]
