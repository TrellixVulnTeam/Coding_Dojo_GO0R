# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2019-07-16 19:55
from __future__ import unicode_literals

import datetime
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('login', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='user',
            name='birthday',
            field=models.DateTimeField(default=datetime.datetime(2019, 7, 16, 12, 55, 6, 218917)),
            preserve_default=False,
        ),
    ]